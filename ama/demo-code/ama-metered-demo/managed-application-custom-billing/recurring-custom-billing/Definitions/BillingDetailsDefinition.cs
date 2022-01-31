using Newtonsoft.Json;

namespace ManagedWebhook.Definitions
{
    /// <summary>
    /// The billing details definition
    /// </summary>
    public class BillingDetailsDefinition
    {
        /// <summary>
        /// Gets or sets the resource usage id.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string ResourceUsageId { get; set; }
    }
}
