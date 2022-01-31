using ManagedWebhook.Definitions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;

namespace ManagedWebhook
{
    public static class Webhook
    {
        public const string DatabaseName = "Applications";
        public const string CollectionName = "Billing";

        [FunctionName("Webhook")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "resource")] HttpRequest req,
            [CosmosDB(
                databaseName: DatabaseName,
                collectionName: CollectionName,
                ConnectionStringSetting = "CosmosDBConnectionString")] DocumentClient documentClient,
            ILogger log,
            ExecutionContext context)
        {
            // Authorize the request based on the sig parameter
            var sig = req.Query["sig"];

            var config = new ConfigurationBuilder()
                .SetBasePath(context.FunctionAppDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            if (!config["URL_SIGNATURE"].Equals(sig, StringComparison.OrdinalIgnoreCase))
            {
                log.LogError($"Unexpected or missing 'sig' parameter value '{sig}'");
                return new UnauthorizedResult();
            }

            using (var streamReader = new StreamReader(req.Body))
            {
                var requestBody = await streamReader
                    .ReadToEndAsync()
                    .ConfigureAwait(continueOnCapturedContext: false);

                log.LogTrace($"Notification payload: {requestBody}");

                var deserializationErrors = new List<string>();

                var notificationDefinition = JsonConvert.DeserializeObject<NotificationDefinition>(
                    value: requestBody,
                    settings: new JsonSerializerSettings
                    {
                        Error = delegate (object sender, ErrorEventArgs args)
                        {
                            deserializationErrors.Add(args.ErrorContext.Error.Message);
                            args.ErrorContext.Handled = true;
                        }
                    });

                if (notificationDefinition == null || deserializationErrors.Any())
                {
                    return new BadRequestObjectResult($"Failed to deserialize request body. Errors: {String.Join(';',deserializationErrors)}");
                }

                if (notificationDefinition.Plan != null)
                {
                    // If provisioning of a marketplace application instance is successful, we persist a billing entry to be picked up by the chron metric emitting job
                    if (notificationDefinition.EventType == "PUT" && notificationDefinition.ProvisioningState == "Succeeded" && notificationDefinition.BillingDetails?.ResourceUsageId != null)
                    {
                        var billingEntry = new BillingEntry
                        {
                            // CosmosDB does not support forward slashes in the id.
                            id = notificationDefinition.ApplicationId.Replace("/", "|"),

                            planId = notificationDefinition.Plan.Name,

                            resourceUsageId = notificationDefinition.BillingDetails.ResourceUsageId,

                            processStatus = false

                            
                        };

                        await documentClient
                            .UpsertDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName), billingEntry)
                            .ConfigureAwait(continueOnCapturedContext: false);

                        log.LogTrace($"Successfully inserted the entry in CosmosDB for the application {notificationDefinition.ApplicationId}");
                    }
                    else if (notificationDefinition.EventType == "DELETE" && notificationDefinition.ProvisioningState == "Deleted" && notificationDefinition.Plan != null)
                    {
                        // On successful deletion of a marketplace application instance try to delete a billing entry in case one was created
                        var docLink = UriFactory.CreateDocumentUri(DatabaseName, CollectionName, notificationDefinition.ApplicationId.Replace("/", "|"));
                        var requestOptions = new RequestOptions { PartitionKey = new PartitionKey(notificationDefinition.Plan.Name) };

                        try 
                        {
                            await documentClient
                                .DeleteDocumentAsync(docLink, requestOptions)
                                .ConfigureAwait(continueOnCapturedContext: false);

                            log.LogTrace($"Successfully deleted the entry in CosmosDB for the application {notificationDefinition.ApplicationId}");
                        }
                        catch (DocumentClientException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
                        {
                            log.LogTrace($"There was no entry in CosmosDB for the deleted application {notificationDefinition.ApplicationId}");
                        }
                    }
                }
            }

            return new OkResult();
        }
    }
}
