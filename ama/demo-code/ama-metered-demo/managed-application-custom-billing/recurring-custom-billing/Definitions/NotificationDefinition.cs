using Newtonsoft.Json;

namespace ManagedWebhook.Definitions
{
    /// <summary>
    /// The notification definition.
    /// </summary>
    public class NotificationDefinition
    {
        /// <summary>
        /// Gets or sets the application resource identifier.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the billing details.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public BillingDetailsDefinition BillingDetails { get; set; }
    }
}
