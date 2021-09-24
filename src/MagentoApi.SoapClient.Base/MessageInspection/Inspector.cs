using System;
using System.Collections.Concurrent;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Xml;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    /// <summary>
    /// Class Inspector.
    /// </summary>
    /// <seealso cref="IClientMessageInspector" />
    public class Inspector : IClientMessageInspector
    {
        /// <summary>
        /// The settings
        /// </summary>
        protected Settings.Settings settings;

        /// <summary>
        /// The tracer
        /// </summary>
        protected Tracer tracer;

        /// <summary>
        /// The namespace modification
        /// </summary>
        protected NamespaceModification namespaceModification;

        /// <summary>
        /// The quantity modification
        /// </summary>
        protected QuantityModification quantityModification;

        /// <summary>
        /// The authorization token
        /// </summary>
        protected AuthorizationToken authorizationToken;

        /// <summary>
        /// The is customer notified modification
        /// </summary>
        protected IsCustomerNotifiedModification isCustomerNotifiedModification;

        /// <summary>
        /// Gets or sets a value indicating whether message should be traced.
        /// </summary>
        /// <value><c>true</c> if message will be traced; otherwise, <c>false</c>.</value>
        public bool TraceMessages { get; set; }

        /// <summary>
        /// Gets or sets the trace messages folder.
        /// </summary>
        /// <value>The trace messages folder.</value>
        public string TraceMessagesFolder { get; set; }

        /// <summary>
        /// Gets or sets the original namespace.
        /// </summary>
        /// <value>The original base namespace.</value>
        public string OriginalNamespace { get; set; }

        /// <summary>
        /// Gets or sets the applied namespace.
        /// </summary>
        /// <value>The namespace.</value>
        public string AppliedNamespace { get; set; }

        /// <summary>
        /// The actions
        /// </summary>
        protected ConcurrentDictionary<Guid, string> actions;

        /// <summary>
        /// Initializes a new instance of the <see cref="Inspector" /> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="tracer">The tracer.</param>
        /// <param name="namespaceModification">The namespace modification.</param>
        /// <param name="quantityModification">The quantity modification.</param>
        /// <param name="authorizationToken">The authorization token.</param>
        /// <param name="isCustomerNotifiedModification">The is customer notified modification.</param>
        public Inspector(
            Settings.Settings settings,
            Tracer tracer,
            NamespaceModification namespaceModification,
            QuantityModification quantityModification,
            AuthorizationToken authorizationToken,
            IsCustomerNotifiedModification isCustomerNotifiedModification)
        {
            this.settings = settings;
            this.tracer = tracer;
            this.quantityModification = quantityModification;
            this.isCustomerNotifiedModification = isCustomerNotifiedModification;
            this.namespaceModification = namespaceModification;
            this.authorizationToken = authorizationToken;
            this.actions = new ConcurrentDictionary<Guid, string>();
        }

        /// <summary>
        /// Befores the send request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="channel">The channel.</param>
        /// <returns>System.Object.</returns>
        private object BeforeSendRequest(ref Message request)
        {
            //
            // Create correlation Id
            //
            var id = Guid.NewGuid();
            var action = request.Headers?.Action ?? string.Empty;
            this.actions.AddOrUpdate(id, action, (key, value) => value);

            //
            // Trace before send request inspection
            //
            this.Trace(id, "1 SendRequest Before", ref request);

            //
            // Convert into XmlDocument
            //
            var doc = ToXmlDocument(ref request, false);

            // Namespace modification
            this.RevertNamespace(doc);

            //
            // Convert back into message
            //
            request = ToMessage(doc, request.Version);

            //
            // Add Authorization Header
            //
            this.authorizationToken.SetToken(this.settings, request);

            //
            // Trace after send request inspection
            //
            this.Trace(id, "2 SendRequest After", ref request);

            return id;
        }

        /// <summary>
        /// Afters the receive reply.
        /// </summary>
        /// <param name="reply">The reply.</param>
        /// <param name="correlationState">State of the correlation.</param>
        protected void AfterReceiveReply(ref Message reply, object correlationState)
        {
            var id = correlationState as Guid? ?? Guid.Empty;

            //
            // Trace before send request inspection
            //
            this.Trace(id, "3 ReceiveReply Before", ref reply);

            //
            // Convert into XmlDocument
            //
            var doc = ToXmlDocument(ref reply, false);

            // Namespace modification
            this.SetNamespace(doc);

            // modify empty <qty> in catalogProductRepositoryV1SaveResponse
            this.quantityModification.Modify(doc);
            this.isCustomerNotifiedModification.Modify(doc);

            //
            // Convert back into message
            //
            reply = ToMessage(doc, reply.Version);

            //
            // Trace after send request inspection
            //
            this.Trace(id, "4 ReceiveReply After", ref reply);

            //
            // Remove Id
            //
            this.actions.TryRemove(id, out _);
        }

        /// <summary>
        /// To the XML document.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="copy">if set to <c>true</c> the original message will be copied so it wont be modified.</param>
        /// <returns>XmlDocument.</returns>
        private static XmlDocument ToXmlDocument(ref Message message, bool copy)
        {
            var workItem = message;

            // one copy goes back

            if (copy)
            {
                var buffer = message.CreateBufferedCopy(int.MaxValue);
                message = buffer.CreateMessage();
                workItem = buffer.CreateMessage();
            }

            using (var memory = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Encoding = Encoding.UTF8,
                };

                using (var xmlWriter = XmlWriter.Create(memory, settings))
                {
                    workItem.WriteMessage(xmlWriter);
                    xmlWriter.Flush();
                    memory.Flush();
                }

                // reset position to start
                memory.Seek(0, SeekOrigin.Begin);

                XmlDocument document = new XmlDocument();
                document.Load(memory);
                return document;
            }
        }

        /// <summary>
        /// To the message.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="version">The version.</param>
        /// <returns>Message.</returns>
        protected static Message ToMessage(XmlDocument document, MessageVersion version)
        {
            var memory = new MemoryStream();

            using (var xmlWriter = XmlWriter.Create(memory, new XmlWriterSettings
            {
                Encoding = System.Text.Encoding.UTF8
            }))
            {

                document.WriteTo(xmlWriter);
                xmlWriter.Flush();
                memory.Flush();
            }

            // reset position to start
            memory.Seek(0, SeekOrigin.Begin);

            return Message.CreateMessage(XmlReader.Create(memory, new XmlReaderSettings { }), int.MaxValue, version);
        }

        #region Namespace Modification

        /// <summary>
        /// Sets the namespace modification
        /// </summary>
        /// <param name="document">The document.</param>
        protected void SetNamespace(XmlDocument document)
        {
            if (string.IsNullOrWhiteSpace(this.AppliedNamespace) || string.IsNullOrWhiteSpace(this.OriginalNamespace))
            {
                return;
            }

            //
            // modify namespace
            //
            this.namespaceModification.Modify(document, this.AppliedNamespace, this.OriginalNamespace);
        }

        /// <summary>
        /// Reverts the namespace modification.
        /// </summary>
        /// <param name="document">The document.</param>
        protected void RevertNamespace(XmlDocument document)
        {
            if (string.IsNullOrWhiteSpace(this.AppliedNamespace) || string.IsNullOrWhiteSpace(this.OriginalNamespace))
            {
                return;
            }

            //
            // modify namespace
            //
            this.namespaceModification.Modify(document, this.OriginalNamespace, this.AppliedNamespace);
        }

        #endregion

        #region Trace

        /// <summary>
        /// Gets the trace filename.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <returns>System.String.</returns>
        protected string GetTraceBaseFilename(Guid id, string name)
        {
            var result = name;
            if (this.actions.TryGetValue(id, out string action))
            {
                result = action + " " + name;
            }
            return id.ToString("N") + " " + result;
        }

        /// <summary>
        /// Traces the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="situation">The situation.</param>
        /// <param name="message">The message.</param>
        protected void Trace(Guid id, string situation, ref Message message)
        {
            // not tracing at all
            if (!this.TraceMessages)
            {
                return;
            }

            // one copy goes back
            var buffer = message.CreateBufferedCopy(int.MaxValue);
            message = buffer.CreateMessage();

            try
            {
                // the other on to trace
                Tracer.Trace(this.TraceMessagesFolder, this.GetTraceBaseFilename(id, situation), buffer.CreateMessage());
            }
            catch { }
        }

        #endregion

        #region Implementation IClientMessageInspector

        /// <summary>
        /// Afters the receive reply.
        /// </summary>
        /// <param name="reply">The reply.</param>
        /// <param name="correlationState">State of the correlation.</param>
        void IClientMessageInspector.AfterReceiveReply(ref Message reply, object correlationState)
        {
            this.AfterReceiveReply(ref reply, correlationState);
        }

        /// <summary>
        /// Befores the send request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="channel">The channel.</param>
        /// <returns>System.Object.</returns>
        object IClientMessageInspector.BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            return this.BeforeSendRequest(ref request);
        }

        #endregion
    }
}
