using ManagedWebhook.Definitions;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
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
            [TimerTrigger("0 0 0/1 * * *")]TimerInfo timerInfo,
            [CosmosDB(
                databaseName: Webhook.DatabaseName,
                collectionName: Webhook.CollectionName,
                ConnectionStringSetting = "CosmosDBConnectionString")] DocumentClient documentClient,
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

            using (var httpClient = HttpClientFactory.Create())
            {
                var token = await CronJob.GetToken(httpClient, config, log).ConfigureAwait(continueOnCapturedContext: false);
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                string sqlExpression = "Select * from c where c.processStatus=false";
                using (var queryable = documentClient.CreateDocumentQuery<BillingEntry>(UriFactory.CreateDocumentCollectionUri(Webhook.DatabaseName, Webhook.CollectionName),sqlExpression).AsDocumentQuery())
                {
                    while (queryable.HasMoreResults)
                    {
                        foreach (var billingEntry in await queryable.ExecuteNextAsync<BillingEntry>().ConfigureAwait(continueOnCapturedContext: false))
                        {
                            foreach (var dimensionConfig in dimensionConfigs)
                            {
                                var response = await CronJob.EmitUsageEvents(config, httpClient, dimensionConfig, billingEntry).ConfigureAwait(continueOnCapturedContext: false);
                                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
                                if (response.IsSuccessStatusCode)
                                {
                                    log.LogTrace($"Successfully emitted a usage event. Reponse body: {responseBody}");

                                    // update cosmosdb document
                                    billingEntry.processStatus=true;
                                    await documentClient.UpsertDocumentAsync(UriFactory.CreateDocumentCollectionUri(Webhook.DatabaseName, Webhook.CollectionName), billingEntry).ConfigureAwait(continueOnCapturedContext: false);
                                }
                                else
                                {
                                    log.LogError($"Failed to emit a usage event. Error code: {response.StatusCode}. Failure cause: {response.ReasonPhrase}. Response body: {responseBody}");
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Emits the usage event to the configured MARKETPLACEAPI_URI.
        /// </summary>
        private static async Task<HttpResponseMessage> EmitUsageEvents(IConfigurationRoot config, HttpClient httpClient, DimensionConfig dimensionConfig, BillingEntry billingEntry)
        {
            var usageEvent = new UsageEventDefinition
            {
                ResourceId = billingEntry.resourceUsageId,
                Quantity = dimensionConfig.Quantity,
                Dimension = dimensionConfig.Dimension,
                EffectiveStartTime = DateTime.UtcNow,
                PlanId = billingEntry.planId
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
        /// Gets the token for the attached user-assigned managed identity.
        /// </summary>
        public static async Task<string> GetToken(HttpClient httpClient, IConfigurationRoot config, ILogger log)
        {
            if (CronJob.IsLocalRun(config))
            {
                return "token";
            }

            // TOKEN_RESOURCE and MSI_CLIENT_ID come from the configs
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"{config["MSI_ENDPOINT"]}/?resource={config["TOKEN_RESOURCE"]}&clientId={config["MSI_CLIENT_ID"]}&api-version=2017-09-01"))
            {
                request.Headers.Add("Secret", config["MSI_SECRET"]);
                var response = await httpClient.SendAsync(request).ConfigureAwait(continueOnCapturedContext: false);
                if (response?.IsSuccessStatusCode != true)
                {
                    log.LogError("Failed to get token for user-assigned MSI. Please check that all the config flags are set properly and the MSI is attached.");
                }
                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
                return JsonConvert.DeserializeObject<TokenDefinition>(responseBody).Access_token;
            }
        }

        /// <summary>
        /// Returns whether the function is run locally.
        /// </summary>
        public static bool IsLocalRun(IConfigurationRoot config)
        {
            return config["LOCAL_RUN"]?.Equals("true", StringComparison.OrdinalIgnoreCase) == true;
        }
    }
}
