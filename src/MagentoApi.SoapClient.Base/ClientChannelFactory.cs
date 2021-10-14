using Compori.MagentoApi.Authentication;
using Compori.MagentoApi.SoapClient.Helpers;
using Compori.MagentoApi.SoapClient.MessageInspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Compori.MagentoApi.SoapClient
{
    /// <summary>
    /// Class ClientChannelFactory.
    /// </summary>
    /// <seealso cref="Compori.Magento.IClientChannelFactory" />
    public class ClientChannelFactory : IClientChannelFactory
    {
        /// <summary>
        /// The default store view code
        /// </summary>
        public const string DefaultStoreViewCode = "default";

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <value>The token.</value>
        private IToken Token { get; }

        /// <summary>
        /// Gets the service registry.
        /// </summary>
        /// <value>The service registry.</value>
        public IServiceRegistry ServiceRegistry { get; private set; }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>The settings.</value>
        public Settings.Settings Settings { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientChannelFactory" /> class.
        /// </summary>
        /// <param name="serviceRegistry">The service registry.</param>
        /// <param name="token">The token.</param>
        /// <param name="settings">The settings.</param>
        public ClientChannelFactory(IServiceRegistry serviceRegistry, IToken token, Settings.Settings settings)
        {
            this.ServiceRegistry = serviceRegistry;
            this.Settings = settings;
            this.Token = token;

            //
            // explizit setting security protocol.
            //
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls13;
        }

        /// <summary>
        /// Creates the transport binding.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>CustomBinding.</returns>
        /// <exception cref="InvalidOperationException">Only https or http transport bindings are supported.</exception>
        private CustomBinding CreateBinding(string name)
        {
            var binding = new CustomBinding
            {
                Name = name
            };

            //
            // Setup text encoding for custom binding
            //
            var textEncoding = new TextMessageEncodingBindingElement
            {
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None)
            };
            binding.Elements.Add(textEncoding);

            //
            // Setup transport for custom binding
            //
            HttpTransportBindingElement transportBindingElement;
            var uri = new Uri(this.Settings.BaseEndpointAddress);
            var scheme = uri.Scheme.ToLowerInvariant();
            switch (scheme)
            {
                case "http":
                    transportBindingElement = new HttpTransportBindingElement();
                    break;
                case "https":
                    transportBindingElement = new HttpsTransportBindingElement();
                    break;
                default:

                    //
                    // Other transport bindings are not supported.
                    //
                    throw new ClientChannelFactoryException("Only https or http transport bindings are supported.");
            }
            transportBindingElement.AllowCookies = true;
            transportBindingElement.TransferMode = TransferMode.Buffered;
            transportBindingElement.MaxBufferSize = this.Settings.Http.TransportMaxReceivedMessageSize;
            transportBindingElement.MaxReceivedMessageSize = this.Settings.Http.TransportMaxReceivedMessageSize;

            binding.Elements.Add(transportBindingElement);

            return binding;
        }

        /// <summary>
        /// Creates the behavior.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="appliedNamespace">The applied namespace.</param>
        /// <returns>IEndpointBehavior.</returns>
        protected IEndpointBehavior CreateBehavior(Settings.Settings settings, string appliedNamespace)
        {
            var tracer = new Tracer();
            var namespaceModification = new NamespaceModification();
            var adminAuthorizationToken = new AuthorizationToken(Token);
            var quantityModification = new QuantityModification();
            var isCustomerNotifiedModification = new IsCustomerNotifiedModification();
            var faultModification = new FaultModification();
            var inspector = new Inspector(
                settings, tracer, 
                namespaceModification, 
                quantityModification, 
                adminAuthorizationToken, 
                isCustomerNotifiedModification,
                faultModification)
            {
                TraceMessages = settings.Trace.Enable,
                TraceMessagesFolder = settings.Trace.MessagesFolder,
                AppliedNamespace = appliedNamespace
            };

            return new Behavior(inspector);
        }

        /// <summary>
        /// Creates the client channel for the specified store.
        /// </summary>
        /// <typeparam name="T">Requested ClientChannel interface</typeparam>
        /// <param name="storeView">The store view.</param>
        /// <returns>T.</returns>
        protected T Create<T>(string storeView)
        {
            //
            // Find service
            //
            var service = this.ServiceRegistry.Find(typeof(T));
            if (service == null)
            {
                throw new ClientChannelFactoryException("Service is not registered.");
            }

            //
            // Check up store view code
            //
            if (storeView == null)
            {
                storeView = DefaultStoreViewCode;
            }
            if (!service.IsStoreViewCapable && !storeView.Equals(DefaultStoreViewCode))
            {
                throw new ClientChannelFactoryException("Service is not store view capable.");
            }

            var endpointHelper = new EndpointHelper();
            var endpointAddress = endpointHelper.CreateEndpointAddress(this.Settings.BaseEndpointAddress, service.Name, storeView);

            //
            // create factory
            //
            var factory = new ChannelFactory<T>(this.CreateBinding(service.Name + "Binding"), endpointAddress);

            factory.Endpoint.EndpointBehaviors.Add(this.CreateBehavior(this.Settings, endpointAddress.Uri.AbsoluteUri));
            factory.Endpoint.Binding.SendTimeout = this.Settings.Http.SendTimeout;

            var client = factory.CreateChannel();
            
            return client;
        }

        /// <summary>
        /// Creates the specified type.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <param name="storeView">The store view.</param>
        /// <returns>IClientChannel.</returns>
        /// <exception cref="ClientChannelFactoryException">Service is not registered.
        /// or
        /// Service is not store view capable.</exception>
        protected IClientChannel Create(string name, string storeView)
        {
            //
            // Find service
            //
            var service = this.ServiceRegistry.Find(name);
            if (service == null)
            {
                throw new ClientChannelFactoryException("Service is not registered.");
            }

            //
            // Check up store view code
            //
            if (storeView == null)
            {
                storeView = DefaultStoreViewCode;
            }
            if (!service.IsStoreViewCapable && !storeView.Equals(DefaultStoreViewCode))
            {
                throw new ClientChannelFactoryException("Service is not store view capable.");
            }

            var endpointHelper = new EndpointHelper();
            var endpointAddress = endpointHelper.CreateEndpointAddress(this.Settings.BaseEndpointAddress, service.Name, storeView);

            //
            // create factory
            //
            var factoryType = typeof(ChannelFactory<>).MakeGenericType(service.Type);
            var factory = Activator.CreateInstance(
                factoryType, 
                new object[] { this.CreateBinding(service.Name + "Binding"), endpointAddress }) as ChannelFactory;

            // var factory = new ChannelFactory<IClientChannel>(this.CreateBinding(service.Name + "Binding"), endpointAddress);
            factory.Endpoint.EndpointBehaviors.Add(this.CreateBehavior(this.Settings, endpointAddress.Uri.AbsoluteUri));
            factory.Endpoint.Binding.SendTimeout = this.Settings.Http.SendTimeout;

            var method = factoryType.GetMethod("CreateChannel", Array.Empty<Type>());
            return method.Invoke(factory, null) as IClientChannel;

            //dynamic f = factory;
            //var client = f.CreateChannel();
            //return client;
        }

        #region IClientChannelFactory Implementation

        /// <summary>
        /// Creates the specified type.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <param name="storeView">The store view.</param>
        /// <returns>IClientChannel.</returns>
        IClientChannel IClientChannelFactory.Create(string name, string storeView)
        {
            return this.Create(name, storeView);
        }

        /// <summary>
        /// Creates the specified type.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <returns>IClientChannel.</returns>
        IClientChannel IClientChannelFactory.Create(string name)
        {
            return this.Create(name, null);
        }

        /// <summary>
        /// Creates the client channel for the specified store.
        /// </summary>
        /// <typeparam name="T">Requested ClientChannel interface</typeparam>
        /// <param name="storeView">The store view.</param>
        /// <returns>T.</returns>
        T IClientChannelFactory.Create<T>(string storeView)
        {
            return this.Create<T>(storeView);
        }

        /// <summary>
        /// Creates the client channel for the default store.
        /// </summary>
        /// <typeparam name="T">Requested ClientChannel interface</typeparam>
        /// <returns>T.</returns>
        T IClientChannelFactory.Create<T>()
        {
            return this.Create<T>(null);
        }

        #endregion
    }
}
