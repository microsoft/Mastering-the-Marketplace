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

namespace SaaSFunctions
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

            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            PrintToLogPayload(data);

            return new OkResult();
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
