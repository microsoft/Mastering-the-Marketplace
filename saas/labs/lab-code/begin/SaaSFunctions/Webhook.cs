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
