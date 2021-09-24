namespace Compori.MagentoApi
{
    public class TraceSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether to trace messages.
        /// </summary>
        /// <value><c>true</c> if trace messages; otherwise, <c>false</c>.</value>
        public bool Enable { get; set; } = false;

        /// <summary>
        /// Gets or sets the trace messages folder.
        /// </summary>
        /// <value>The trace messages folder.</value>
        public string MessagesFolder { get; set; }
    }
}
