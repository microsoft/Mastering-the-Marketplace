namespace ManagedWebhook.Definitions
{
    /// <summary>
    /// The billing entry that gets saved in CosmosDB.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "CosmosDB is case sensitive.")]
    public class BillingEntry
    {

        /// <summary>
        /// Gets or sets the identifier, which is the application resource identifier.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the plan identifier.
        /// </summary>
        public string planId { get; set; }

        /// <summary>
        /// Gets or sets the resource usage identifier.
        /// </summary>
        public string resourceUsageId { get; set; }

        public bool processStatus { get; set; }
    }
}
