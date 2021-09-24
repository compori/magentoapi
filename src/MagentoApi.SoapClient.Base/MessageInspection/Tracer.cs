using System;
using System.IO;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    /// <summary>
    /// Class Tracer traces Message from and to magneto server.
    /// </summary>
    public class Tracer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tracer"/> class.
        /// </summary>
        public Tracer()
        {
        }

        /// <summary>
        /// Traces the specified directory.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="baseFilename">The base filename.</param>
        /// <param name="message">The message.</param>
        public static void Trace(string directory, string baseFilename, Message message)
        {
            TraceProperties(directory, baseFilename + ".txt", message);
            TraceMessage(directory, baseFilename + ".xml", message);
        }

        /// <summary>
        /// Traces the message message.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="filename">The filename.</param>
        /// <param name="message">The request.</param>
        public static void TraceMessage(string directory, string filename, Message message)
        {
            if (message == null)
            {
                return;
            }

            // Directory does not exists.
            if (!Directory.Exists(directory))
            {
                return;
            }

            //
            // Write to Message to file
            //
            using (var traceStream = new FileStream(Path.Combine(directory, filename), FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Encoding = Encoding.UTF8,
                    Indent = true,
                };

                using (var xmlWriter = XmlWriter.Create(traceStream, settings))
                {
                    message.WriteMessage(xmlWriter);
                    xmlWriter.Flush();
                    traceStream.Flush();
                }
            }
        }

        /// <summary>
        /// Traces the message properties.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="filename">The filename.</param>
        /// <param name="message">The request.</param>
        public static void TraceProperties(string directory, string filename, Message message)
        {
            if (message == null)
            {
                return;
            }

            // Directory does not exists.
            if (!Directory.Exists(directory))
            {
                return;
            }

            //
            // Write to message properties to file
            //
            using (var traceStream = new FileStream(Path.Combine(directory, filename), FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var textStream = new StreamWriter(traceStream, Encoding.UTF8))
                {

                    //
                    // Write Header
                    //
                    textStream.WriteLine("Message".PadRight(80, '.'));
                    textStream.WriteLine();
                    textStream.WriteLine("Version.Addressing       : " + message.Version?.Addressing ?? "N/A");
                    textStream.WriteLine("Version.Envelope         : " + message.Version?.Envelope ?? "N/A");
                    textStream.WriteLine("IsEmpty                  : " + message.IsEmpty.ToString());
                    textStream.WriteLine("IsFault                  : " + message.IsFault.ToString());
                    textStream.WriteLine();

                    if (message.Headers != null)
                    {
                        textStream.WriteLine("Headers");
                        textStream.WriteLine("Action                   : " + message.Headers.Action ?? "N/A");
                        textStream.WriteLine();
                    }

                    //
                    // Write properties
                    //
                    foreach (var property in message.Properties)
                    {
                        //
                        // Write the HttpRequestMessageProperty
                        //
                        if (property.Value is HttpRequestMessageProperty httpRequest)
                        {
                            textStream.WriteLine(nameof(HttpRequestMessageProperty).PadRight(80, '.'));
                            textStream.WriteLine("Method                   : " + httpRequest.Method);
                            textStream.WriteLine("QueryString              : " + httpRequest.QueryString);
                            textStream.WriteLine("SuppressEntityBody       : " + httpRequest.SuppressEntityBody.ToString());

                            if (httpRequest.Headers != null)
                            {
                                // Write additional header information
                                textStream.WriteLine("Http Headers ".PadRight(80, '-'));

                                foreach (var headerEntry in httpRequest.Headers.AllKeys)
                                {
                                    textStream.WriteLine(String.Format("{0}:\t{1}", headerEntry, httpRequest.Headers.Get(headerEntry)));
                                }

                                if (httpRequest.Headers.Count == 0)
                                {
                                    textStream.WriteLine("<none>");
                                }

                                textStream.WriteLine(nameof(HttpRequestMessageProperty).PadLeft(80, '.'));
                                textStream.WriteLine();
                            }
                        }

                        //
                        // Write the HttpRequestMessageProperty
                        //
                        if (property.Value is HttpResponseMessageProperty httpResponse)
                        {
                            textStream.WriteLine(nameof(HttpResponseMessageProperty).PadRight(80, '.'));
                            textStream.WriteLine("StatusCode               : " + httpResponse.StatusCode);
                            textStream.WriteLine("StatusDescription        : " + httpResponse.StatusDescription);

                            if (httpResponse.Headers != null)
                            {
                                // Write additional header information
                                textStream.WriteLine("Http Headers ".PadRight(80, '-'));

                                foreach (var headerEntry in httpResponse.Headers.AllKeys)
                                {
                                    textStream.WriteLine(String.Format("{0}:\t{1}", headerEntry, httpResponse.Headers.Get(headerEntry)));
                                }

                                if (httpResponse.Headers.Count == 0)
                                {
                                    textStream.WriteLine("<none>");
                                }
                            }
                            textStream.WriteLine(nameof(HttpResponseMessageProperty).PadLeft(80, '.'));
                            textStream.WriteLine();
                        }
                    }

                    textStream.WriteLine("Message".PadLeft(80, '.'));
                }
            }
        }
    }

}
