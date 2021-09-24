using System;
using System.ServiceModel;

namespace Compori.MagentoApi.SoapClient.Helpers
{
    public class EndpointHelper
    {
        /// <summary>
        /// Creates the url address.
        /// </summary>
        /// <param name="baseEndpointAddress">The base endpoint address.</param>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="storeView">The store view.</param>
        /// <returns>System.String.</returns>
        public string CreateAddress(string baseEndpointAddress, string serviceName, string storeView)
        {
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                throw new ArgumentException("Service name must not be null or empty.", nameof(serviceName));
            }
            if (string.IsNullOrWhiteSpace(storeView))
            {
                throw new ArgumentException("Store view code must not be null or empty.", nameof(storeView));
            }

            var builder = new UriBuilder(baseEndpointAddress);

            //
            // Setup the address <url base> + /soap/<store>?service=<service name>
            //
            // store can be
            // 1. default
            // 2. storeView code
            // 3. all
            if (!builder.Path.EndsWith("/"))
            {
                builder.Path += "/";
            }
            builder.Path += "soap/" + storeView;

            //
            // Add service name with ?service=ServiceXYZ
            //
            builder.Query = "services=" + serviceName;

            // suppress ports in toString()
            if((builder.Scheme == "http") && builder.Port == 80)
            {
                builder.Port = -1;
            }
            if ((builder.Scheme == "https") && builder.Port == 443)
            {
                builder.Port = -1;
            }
            return builder.ToString();
        }

        /// <summary>
        /// Creates the endpoint address.
        /// </summary>
        /// <param name="baseEndpointAddress">The base endpoint address.</param>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="storeView">The store view.</param>
        /// <returns>EndpointAddress.</returns>
        public EndpointAddress CreateEndpointAddress(string baseEndpointAddress, string serviceName, string storeView)
        {
            return new EndpointAddress(this.CreateAddress(baseEndpointAddress, serviceName, storeView));
        }
    }
}
