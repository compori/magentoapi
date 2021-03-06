//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1")]
    public partial class GenericFault
    {
        
        private string traceField;
        
        private GenericFaultParameter[] parametersField;
        
        private WrappedError[] wrappedErrorsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Trace
        {
            get
            {
                return this.traceField;
            }
            set
            {
                this.traceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GenericFaultParameter[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public WrappedError[] WrappedErrors
        {
            get
            {
                return this.wrappedErrorsField;
            }
            set
            {
                this.wrappedErrorsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1")]
    public partial class GenericFaultParameter
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1")]
    public partial class WrappedError
    {
        
        private string messageField;
        
        private GenericFaultParameter[] parametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GenericFaultParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1")]
    public partial class QuoteDataShippingMethodExtensionInterface
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1")]
    public partial class QuoteDataShippingMethodInterface
    {
        
        private string carrierCodeField;
        
        private string methodCodeField;
        
        private string carrierTitleField;
        
        private string methodTitleField;
        
        private float amountField;
        
        private float baseAmountField;
        
        private bool availableField;
        
        private QuoteDataShippingMethodExtensionInterface extensionAttributesField;
        
        private string errorMessageField;
        
        private float priceExclTaxField;
        
        private float priceInclTaxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string carrierCode
        {
            get
            {
                return this.carrierCodeField;
            }
            set
            {
                this.carrierCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string methodCode
        {
            get
            {
                return this.methodCodeField;
            }
            set
            {
                this.methodCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string carrierTitle
        {
            get
            {
                return this.carrierTitleField;
            }
            set
            {
                this.carrierTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string methodTitle
        {
            get
            {
                return this.methodTitleField;
            }
            set
            {
                this.methodTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public float amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public float baseAmount
        {
            get
            {
                return this.baseAmountField;
            }
            set
            {
                this.baseAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public QuoteDataShippingMethodExtensionInterface extensionAttributes
        {
            get
            {
                return this.extensionAttributesField;
            }
            set
            {
                this.extensionAttributesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string errorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public float priceExclTax
        {
            get
            {
                return this.priceExclTaxField;
            }
            set
            {
                this.priceExclTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public float priceInclTax
        {
            get
            {
                return this.priceInclTaxField;
            }
            set
            {
                this.priceInclTaxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1")]
    public partial class QuoteGuestShippingMethodManagementV1GetListResponse
    {
        
        private QuoteDataShippingMethodInterface[] resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public QuoteDataShippingMethodInterface[] result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1")]
    public partial class QuoteGuestShippingMethodManagementV1GetListRequest
    {
        
        private string cartIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cartId
        {
            get
            {
                return this.cartIdField;
            }
            set
            {
                this.cartIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
        "hodManagementV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippin" +
        "gMethodManagementV1.quoteGuestShippingMethodManagementV1PortType")]
    public interface quoteGuestShippingMethodManagementV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="quoteGuestShippingMethodManagementV1GetList", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.GenericFault), Action="quoteGuestShippingMethodManagementV1GetList", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1GetListResponse1> quoteGuestShippingMethodManagementV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1GetListRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class quoteGuestShippingMethodManagementV1GetListRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
            "hodManagementV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.QuoteGuestShippingMethodManagementV1GetListRequest quoteGuestShippingMethodManagementV1GetListRequest;
        
        public quoteGuestShippingMethodManagementV1GetListRequest1()
        {
        }
        
        public quoteGuestShippingMethodManagementV1GetListRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.QuoteGuestShippingMethodManagementV1GetListRequest quoteGuestShippingMethodManagementV1GetListRequest)
        {
            this.quoteGuestShippingMethodManagementV1GetListRequest = quoteGuestShippingMethodManagementV1GetListRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class quoteGuestShippingMethodManagementV1GetListResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
            "hodManagementV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.QuoteGuestShippingMethodManagementV1GetListResponse quoteGuestShippingMethodManagementV1GetListResponse;
        
        public quoteGuestShippingMethodManagementV1GetListResponse1()
        {
        }
        
        public quoteGuestShippingMethodManagementV1GetListResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.QuoteGuestShippingMethodManagementV1GetListResponse quoteGuestShippingMethodManagementV1GetListResponse)
        {
            this.quoteGuestShippingMethodManagementV1GetListResponse = quoteGuestShippingMethodManagementV1GetListResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface quoteGuestShippingMethodManagementV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class quoteGuestShippingMethodManagementV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public quoteGuestShippingMethodManagementV1PortTypeClient() : 
                base(quoteGuestShippingMethodManagementV1PortTypeClient.GetDefaultBinding(), quoteGuestShippingMethodManagementV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.quoteGuestShippingMethodManagementV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteGuestShippingMethodManagementV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(quoteGuestShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), quoteGuestShippingMethodManagementV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteGuestShippingMethodManagementV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(quoteGuestShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteGuestShippingMethodManagementV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(quoteGuestShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteGuestShippingMethodManagementV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1GetListResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1PortType.quoteGuestShippingMethodManagementV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1GetListRequest1 request)
        {
            return base.Channel.quoteGuestShippingMethodManagementV1GetListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1GetListResponse1> quoteGuestShippingMethodManagementV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.QuoteGuestShippingMethodManagementV1GetListRequest quoteGuestShippingMethodManagementV1GetListRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1GetListRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1GetListRequest1();
            inValue.quoteGuestShippingMethodManagementV1GetListRequest = quoteGuestShippingMethodManagementV1GetListRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteGuestShippingMethodManagementV1.quoteGuestShippingMethodManagementV1PortType)(this)).quoteGuestShippingMethodManagementV1GetListAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.quoteGuestShippingMethodManagementV1Port))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.quoteGuestShippingMethodManagementV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=quoteGuestShippingMet" +
                        "hodManagementV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return quoteGuestShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.quoteGuestShippingMethodManagementV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return quoteGuestShippingMethodManagementV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.quoteGuestShippingMethodManagementV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            quoteGuestShippingMethodManagementV1Port,
        }
    }
}
