using Compori.MagentoApi.Authentication;
using System.ServiceModel.Channels;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    /// <summary>
    /// Class AdminAuthorizationToken.
    /// </summary>
    public class AuthorizationToken
    {
        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <value>The token.</value>
        private IToken Token { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationToken" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        public AuthorizationToken(IToken token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Gets the HTTP request message property.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>HttpRequestMessageProperty.</returns>
        private static HttpRequestMessageProperty GetOrAddHttpRequestProperty(Message request)
        {
            if (!request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
            {
                request.Properties.Add(HttpRequestMessageProperty.Name, new HttpRequestMessageProperty());
            }
            return request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
        }

        /// <summary>
        /// Sets the token into the Message.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="message">The request.</param>
        public void SetToken(Settings.Settings settings, Message message)
        {
            // Could not async/await here because caller will ref
            var token = this.Token.CreateAsync().GetAwaiter().GetResult();
            if (string.IsNullOrEmpty(token))
            {
                return;
            }

            // set token
            var httpRequestProperty = GetOrAddHttpRequestProperty(message);
            httpRequestProperty.Headers["Authorization"] = "Bearer " + token;
            
            // additionally add user agent to head
            if (!string.IsNullOrWhiteSpace(settings.UserAgent))
            {
                httpRequestProperty.Headers[System.Net.HttpRequestHeader.UserAgent] = settings.Http.UserAgent;
            }
        }
    }

}
