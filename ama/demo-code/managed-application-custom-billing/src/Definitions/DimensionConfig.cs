using Newtonsoft.Json;

namespace ManagedWebhook.Definitions
{
    /// <summary>
    /// Mock dimension config.
    /// </summary>
    class DimensionConfig
    {
        /// <summary>
        /// The desired mock dimension name.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Dimension { get; set; }

        /// <summary>
        /// The desired mock quantity for the dimension.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public double Quantity { get; set; }
    }
}
