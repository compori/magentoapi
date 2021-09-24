using Compori.MagentoApi.Authentication;

namespace Compori.MagentoApi.Settings
{
    /// <summary>
    /// The class Settings is a plain data object for configuration data.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Gets or sets the base endpoint address that points to the magento server.
        /// </summary>
        /// <value>The base endpoint address.</value>
        public string BaseEndpointAddress { get; set; }
        
        /// <summary>
        /// Gets or sets the user agent name.
        /// </summary>
        /// <value>The user agent name.</value>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the token settings.
        /// </summary>
        /// <value>The token settings.</value>
        public TokenSettings Token { get; set; }        

        /// <summary>
        /// Gets or sets the trace settings.
        /// </summary>
        /// <value>The trace settings.</value>
        public TraceSettings Trace { get; set; } = new TraceSettings();

        /// <summary>
        /// Gets or sets the HTTP settings.
        /// </summary>
        /// <value>The HTTP settings.</value>
        public HttpSettings Http { get; set; } = new HttpSettings();
    }
}
