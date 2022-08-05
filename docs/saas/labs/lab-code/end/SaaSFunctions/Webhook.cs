using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace SaasFunctions
{
    public static class Webhook
    {
        private static HttpRequest _request = null;
        private static ILogger _logger = null;
        private static ExecutionContext _executionContext = null;

        /// <summary>
        /// This function is called by Azure when an event occurs on a subscription in the Azure marketplace.
        /// It needs to be configured in Partner Center to be called by the Azure marketplace.
        /// </summary>
        /// <param name="req">HttpRequest</param>
        /// <param name="log">ILogger</param>
        /// <param name="context">ExecutionContext</param>
        /// <returns>Task<IActionResult></returns>
        [FunctionName("Webhook")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log,
            ExecutionContext context)
        {
            _request = req;
            _logger = log;
            _executionContext = context;

            PrintToLogHeader();

            if (!RequestIsSecure())
            {
                _logger.LogInformation("Security checks did not pass!");
                return new StatusCodeResult((int)HttpStatusCode.Forbidden);
            }

            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            if (!SubscriptionEventIsValid(data))
            {
                _logger.LogInformation("Event informtion was invalid!");
                return new StatusCodeResult((int)HttpStatusCode.Conflict);
            }

            PrintToLogPayload(data);

            return new OkResult();
        }

        /// <summary>
        /// Calls functions that check various security aspects of this webhook
        /// </summary>
        /// <returns>bool indicating if the request is secure</returns>
        private static bool RequestIsSecure()
        {
            // set up the configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(_executionContext.FunctionAppDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            if (!QueryStringIsValid(config))
            {
                _logger.LogInformation("Querystring is invalid.");
                return false;
            }

            if (!ClaimsAreValid(config))
            {
                _logger.LogInformation("Claims are invalid.");
                return false;
            }

            return true;

        }

        /// <summary>
        /// Checks that JWT claims are valid
        /// </summary>
        /// <param name="config">IConfigurationRoot</param>
        /// <returns>A bool indicating if the Claims in the JWT are valid.</returns>
        private static bool ClaimsAreValid(IConfigurationRoot config)
        {
            string authHeader = _request.Headers["Authorization"];

            var jwt = authHeader.Split(' ')[1];
            var handler = new JwtSecurityTokenHandler();

            if (!handler.CanReadToken(jwt))
            {
                _logger.LogInformation("Can't read JWT");
                return false;
            }

            var jwtToken = handler.ReadToken(jwt) as JwtSecurityToken;

            var appId = jwtToken.Claims.FirstOrDefault(c => c.Type == "appid").Value;
            var tenantId = jwtToken.Claims.FirstOrDefault(c => c.Type == "tid").Value;
            var issuer = jwtToken.Claims.FirstOrDefault(c => c.Type == "iss").Value;

            if (appId != config["Auth:ApplicationId"])
            {
                _logger.LogInformation("Application ID does not match.");
                _logger.LogInformation($"Configured Application ID: {config["Auth:ApplicationId"]}");
                _logger.LogInformation($"Received Application ID: {appId}");

                return false;
            }

            if (tenantId != config["Auth:TenantId"])
            {
                _logger.LogInformation("Tenant ID does not match.");
                _logger.LogInformation($"Configured Tenant ID: {config["Auth:ApplicationId"]}");
                _logger.LogInformation($"Received Tenant ID: {tenantId}");
                return false;
            }

            var validIssuer = $"https://sts.windows.net/{tenantId}/";
            if (validIssuer != issuer)
            {
                _logger.LogInformation("Issuer does not match.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks that the secret on the querystring is present and correct
        /// </summary>
        /// <param name="config">IConfigurationRoot</param>
        /// <returns>A bool indicating if the querystring is valid.</returns>
        private static bool QueryStringIsValid(IConfigurationRoot config)
        {
            // get the env:Variables
            var secretKey = config["QueryStringSecret:SecretKey"];
            var secretValue = config["QueryStringSecret:SecretValue"];

            // ensure the key/value exists
            if (_request.Query[secretKey].Count == 0)
            {
                _logger.LogInformation("No secret key on query string.");
                _logger.LogInformation($"Expected: {secretKey}");
                return false;
            }

            // look for a match on the SecretValue
            var token = _request.Query[secretKey][0];
            if (secretValue != token)
            {
                _logger.LogInformation("Wrong secret value on query string.");
                _logger.LogInformation($"Expected: {secretValue}");

                return false;
            }

            return true;
        }

        /// <summary>
        /// Check the event actully occured
        /// </summary>
        /// <param name="data">the JSON paylod s a dynamic value</param>
        /// <returns>Whether of the the reported event is a valid one</returns>
        private static bool SubscriptionEventIsValid(dynamic data)
        {
            switch (data.action)
            {
                case "Unsubscribed":
                    // 1. Use the SaaS Fulfillment API to fetch the relevant subscription
                    // 2. Check the subscription's "saasSubscriptionStatus": "Unsubscribed"
                    // 3. Return false on unexpected result
                    break;

                case "ChangePlan":
                    // 1. Use the SaaS Operation API to validate a ChangePlan has been requested
                    // 2. return false on unexpected result
                    break;

                    // etc.
            }

            return true;
        }

        private static void PrintToLogHeader()
        {
            _logger.LogInformation("===================================");
            _logger.LogInformation("SaaS WEBHOOK FUNCTION FIRING");
            _logger.LogInformation("-----------------------------------");
        }

        private static void PrintToLogPayload(dynamic data)
        {
            _logger.LogInformation($"ACTION: {data.action}");
            _logger.LogInformation("-----------------------------------");
            _logger.LogInformation((string)data.ToString());
            _logger.LogInformation("===================================");
        }
    }
}
