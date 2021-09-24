using System;

namespace Compori.MagentoApi.Settings
{
    public class HttpSettings
    {
        /// <summary>
        /// Gets the default HTTP send timeout.
        /// </summary>
        /// <value>The default HTTP send timeout.</value>
        public static TimeSpan DefaultSendTimeout => new TimeSpan(0, 5, 0);

        /// <summary>
        /// Gets the default size of the HTTP transport maximum received message.
        /// </summary>
        /// <value>The default size of the HTTP transport maximum received message.</value>
        public static int DefaultTransportMaxReceivedMessageSize => 10485760;

        /// <summary>
        /// Gets or sets the user agent name.
        /// </summary>
        /// <value>The user agent name.</value>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the received message.
        /// </summary>
        /// <value>The maximum size of the received message.</value>
        public int TransportMaxReceivedMessageSize { get; set; } = DefaultTransportMaxReceivedMessageSize;

        /// <summary>
        /// Gets or sets the HTTP send timeout.
        /// </summary>
        /// <value>The HTTP send timeout.</value>
        public TimeSpan SendTimeout { get; set; } = DefaultSendTimeout;
    }
}
