using Compori.MagentoApi.Authentication;
using System;
using System.Xml;

namespace Compori.MagentoApi.Settings
{
    public class Loader
    {
        /// <summary>
        /// Parses the time span.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>TimeSpan.</returns>
        public static TimeSpan? ParseTimeSpan(string value, TimeSpan? defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return defaultValue;
            }
            if (TimeSpan.TryParse(value, out TimeSpan result))
            {
                return result;
            }
            return defaultValue;
        }

        /// <summary>
        /// Parses the boolean value.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="defaultValue">Default boolean value if value could not be parsed.</param>
        /// <returns><c>true</c> if value represents true, <c>false</c> otherwise.</returns>
        public static bool ParseBoolean(string value, bool defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return defaultValue;
            }

            if (bool.TryParse(value, out bool result))
            {
                return result;
            }

            return ParseInt32(value, defaultValue ? 1 : 0) != 0;
        }

        /// <summary>
        /// Parses the int32.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Int32.</returns>
        public static int ParseInt32(string value, int defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return defaultValue;
            }
            var culture = System.Globalization.CultureInfo.InvariantCulture.Clone() as System.Globalization.CultureInfo;
            culture.NumberFormat.NumberGroupSeparator = ".";
            if (int.TryParse(value,
                System.Globalization.NumberStyles.AllowThousands
                | System.Globalization.NumberStyles.AllowLeadingWhite
                | System.Globalization.NumberStyles.AllowLeadingSign
                | System.Globalization.NumberStyles.AllowTrailingWhite
                | System.Globalization.NumberStyles.AllowTrailingSign,
                culture, out int result))
            {
                return result;
            }
            return defaultValue;
        }

        /// <summary>
        /// Parses the type of the token.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>TokenType.</returns>
        public static TokenType ParseTokenType(string value, TokenType defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return defaultValue;
            }

            switch (value.ToUpperInvariant())
            {
                case "INTEGRATION":
                    return TokenType.Integration;
                case "ADMIN":
                    return TokenType.Admin;
                case "CUSTOMER":
                    return TokenType.Customer;
                default:
                    return defaultValue;
            }
        }

        /// <summary>
        /// Loads the token settings.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns>TokenSettings.</returns>
        public static TokenSettings LoadTokenSettings(XmlDocument doc)
        {
            var tokenType = ParseTokenType(doc.SelectSingleNode("/settings/token/type")?.InnerText, TokenType.Undefined);

            if(tokenType == TokenType.Integration)
            {
                return new TokenSettings
                {
                    TokenType = tokenType,
                    AccessToken = doc.SelectSingleNode("/settings/token/accessToken")?.InnerText
                };
            }
            return new TokenSettings()
            {
                TokenType = tokenType,
                BaseEndpointAddress = doc.SelectSingleNode("/settings/token/baseEndpointAddress")?.InnerText,
                RequestUserName = doc.SelectSingleNode("/settings/token/requestUserName")?.InnerText,
                RequestPassword = doc.SelectSingleNode("/settings/token/requestPassword")?.InnerText,
                HttpAuthenticationUser = doc.SelectSingleNode("/settings/token/httpBasicAuthenticationUserName")?.InnerText,
                HttpAuthenticationPassword = doc.SelectSingleNode("/settings/token/httpBasicAuthenticationPassword")?.InnerText,
                UserAgent = doc.SelectSingleNode("/settings/token/userAgent")?.InnerText,
                ExpirationPeriod = ParseTimeSpan(doc.SelectSingleNode("/settings/token/expirationPeriod")?.InnerText, null),
            };
        }

        /// <summary>
        /// Loads the trace settings.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns>TraceSettings.</returns>
        public static TraceSettings LoadTraceSettings(XmlDocument doc)
        {
            return new TraceSettings()
            {
                Enable = ParseBoolean(doc.SelectSingleNode("/settings/trace/enable")?.InnerText, false),
                MessagesFolder = doc.SelectSingleNode("/settings/trace/messagesFolder")?.InnerText
            };
        }

        /// <summary>
        /// Loads the HTTP settings.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns>HttpSettings.</returns>
        public static HttpSettings LoadHttpSettings(XmlDocument doc)
        {
            return new HttpSettings()
            {
                UserAgent = doc.SelectSingleNode("/settings/http/userAgent")?.InnerText,
                TransportMaxReceivedMessageSize = ParseInt32(doc.SelectSingleNode("/settings/http/transportMaxReceivedMessageSize")?.InnerText, HttpSettings.DefaultTransportMaxReceivedMessageSize),
                SendTimeout = ParseTimeSpan(doc.SelectSingleNode("/settings/http/sendTimeout")?.InnerText, HttpSettings.DefaultSendTimeout).Value
            };
        }

        /// <summary>
        /// Loads the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>Settings.</returns>
        public static Settings Load(string fileName)
        {
            var doc = new XmlDocument();

            doc.Load(fileName);

            var result = new Settings
            {
                UserAgent = doc.SelectSingleNode("/settings/userAgent")?.InnerText,
                BaseEndpointAddress = doc.SelectSingleNode("/settings/baseEndpointAddress")?.InnerText,
                Token = LoadTokenSettings(doc),
                Trace = LoadTraceSettings(doc),
                Http = LoadHttpSettings(doc),
            };

            result.Token.BaseEndpointAddress = result.Token.BaseEndpointAddress ?? result.BaseEndpointAddress;
            result.Token.UserAgent = result.Token.UserAgent ?? result.UserAgent;
            result.Http.UserAgent = result.Http.UserAgent ?? result.UserAgent;

            return result;
        }
    }
}
