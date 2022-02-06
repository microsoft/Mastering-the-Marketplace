using Newtonsoft.Json;

namespace ManagedWebhook.Definitions
{
    /// <summary>
    /// The application definition
    /// </summary>
    public class ApplicationDefinition
    {
        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public ApplicationProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public Plan Plan { get; set; }
    }
}
