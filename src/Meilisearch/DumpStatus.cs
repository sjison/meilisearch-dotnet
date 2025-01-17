namespace Meilisearch
{
    /// <summary>
    /// Dump Status of the actions done.
    /// </summary>
    public class DumpStatus
    {
        /// <summary>
        /// Gets or sets unique dump identifier.
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets state of the operation.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets started at of the operation.
        /// </summary>
        public string StartedAt { get; set; }

        /// <summary>
        /// Gets or sets finished at of the operation.
        /// </summary>
        public string FinishedAt { get; set; }
    }
}
