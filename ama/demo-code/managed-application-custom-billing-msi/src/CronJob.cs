using ManagedWebhook.Definitions;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebhook
{
    public static class CronJob
    {
        [FunctionName("CronJob")]
        public static async Task Run(
            [TimerTrigger("0 0/5 * * * *")]TimerInfo timerInfo,
            ILogger log,
            ExecutionContext context)
        {
            var config = new ConfigurationBuilder()
             .SetBasePath(context.FunctionAppDirectory)
             .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
             .AddEnvironmentVariables()
             .Build();

            var dimensionConfigs = JsonConvert.DeserializeObject<DimensionConfig[]>(config["DIMENSION_CONFIG"]);
            log.LogTrace($"Dimension configs: {JsonConvert.SerializeObject(dimensionConfigs)}");

            using (var armHttpClient = HttpClientFactory.Create())
            {
                var armToken = await CronJob.GetToken(config, armHttpClient, log, "https://management.core.windows.net/").ConfigureAwait(continueOnCapturedContext: false);
                armHttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {armToken}");

                var applicationResourceId = await CronJob.GetResourceGroupManagedBy(config, armHttpClient, log).ConfigureAwait(continueOnCapturedContext: false);
                var application = await CronJob.GetApplication(applicationResourceId, config, armHttpClient, log).ConfigureAwait(continueOnCapturedContext: false);

                if (application != null)
                {
                    log.LogInformation($"Authorization bearer token: {armToken}");
                    log.LogInformation($"Resource usage id: {application.Properties.BillingDetails?.ResourceUsageId}");
                    log.LogInformation($"Plan name: {application.Plan.Name}");

                    foreach (var dimensionConfig in dimensionConfigs)
                    {
                        var response = await CronJob.EmitUsageEvents(config, armHttpClient, dimensionConfig, application.Properties.BillingDetails?.ResourceUsageId, application.Plan.Name).ConfigureAwait(continueOnCapturedContext: false);
                        var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
                        if (response.IsSuccessStatusCode)
                        {
                            log.LogTrace($"Successfully emitted a usage event. Reponse body: {responseBody}");
                        }
                        else
                        {
                            log.LogError($"Failed to emit a usage event. Error code: {response.StatusCode}. Failure cause: {response.ReasonPhrase}. Response body: {responseBody}");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets the token for the system-assigned managed identity.
        /// </summary>
        private static async Task<string> GetToken(IConfigurationRoot config, HttpClient httpClient, ILogger log, string resource)
        {
            if (CronJob.IsLocalRun(config))
            {
                return "token";
            }

            // TOKEN_RESOURCE come from the configs
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"{config["MSI_ENDPOINT"]}/?resource={resource}&api-version=2017-09-01"))
            {
                request.Headers.Add("Secret", config["MSI_SECRET"]);
                var response = await httpClient.SendAsync(request).ConfigureAwait(continueOnCapturedContext: false);
                if (response?.IsSuccessStatusCode != true)
                {
                    log.LogError($"Failed to get token for system-assigned MSI. Please check that the MSI is set up properly. Error: {response.Content.ReadAsStringAsync().Result}");
                }
                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
                return JsonConvert.DeserializeObject<TokenDefinition>(responseBody).Access_token;
            }
        }

        /// <summary>
        /// Gets the resource group managed by property.
        /// </summary>
        private static async Task<string> GetResourceGroupManagedBy(IConfigurationRoot config, HttpClient httpClient, ILogger log)
        {
            var resourceGroupResponse = await httpClient.GetAsync($"https://management.azure.com{config["RESOURCEGROUP_ID"]}?api-version=2019-11-01").ConfigureAwait(continueOnCapturedContext: false);
            if (resourceGroupResponse?.IsSuccessStatusCode != true)
            {
                log.LogError($"Failed to get the resource group from ARM. Error: {resourceGroupResponse.Content.ReadAsStringAsync().Result}");
                return null;
            }

            var resourceGroup = await resourceGroupResponse.Content.ReadAsAsync<ResourceGroupDefinition>().ConfigureAwait(continueOnCapturedContext: false);

            if (string.IsNullOrEmpty(resourceGroup?.ManagedBy))
            {
                log.LogError("The managedBy property either empty or missing for resource group.");
            }

            return resourceGroup?.ManagedBy;
        }

        /// <summary>
        /// Gets the application.
        /// </summary>
        private static async Task<ApplicationDefinition> GetApplication(string applicationResourceId, IConfigurationRoot config, HttpClient httpClient, ILogger log)
        {
            if (applicationResourceId == null)
            {
                return null;
            }

            var getApplicationResponse = await httpClient.GetAsync($"https://management.azure.com{applicationResourceId}?api-version=2019-07-01").ConfigureAwait(continueOnCapturedContext: false);
            if (getApplicationResponse?.IsSuccessStatusCode != true)
            {
                log.LogError("Failed to get the appplication from ARM.");
                return null;
            }

            return await getApplicationResponse.Content.ReadAsAsync<ApplicationDefinition>().ConfigureAwait(continueOnCapturedContext: false);
        }

        /// <summary>
        /// Emits the usage event to the configured MARKETPLACEAPI_URI.
        /// </summary>
        private static async Task<HttpResponseMessage> EmitUsageEvents(IConfigurationRoot config, HttpClient httpClient, DimensionConfig dimensionConfig, string resourceUsageId, string planId)
        {
            var usageEvent = new UsageEventDefinition
            {
                ResourceId = resourceUsageId,
                Quantity = dimensionConfig.Quantity,
                Dimension = dimensionConfig.Dimension,
                EffectiveStartTime = DateTime.UtcNow,
                PlanId = planId
            };

            if (CronJob.IsLocalRun(config))
            {
                return new HttpResponseMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(usageEvent), UnicodeEncoding.UTF8, "application/json"),
                    StatusCode = HttpStatusCode.OK
                };
            }
            return await httpClient.PostAsJsonAsync(config["MARKETPLACEAPI_URI"], usageEvent).ConfigureAwait(continueOnCapturedContext: false);
        }

        /// <summary>
        /// Returns whether the function is run locally.
        /// </summary>
        private static bool IsLocalRun(IConfigurationRoot config)
        {
            return config["LOCAL_RUN"]?.Equals("true", StringComparison.OrdinalIgnoreCase) == true;
        }
    }
}
