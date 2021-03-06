//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1")]
    public partial class SalesCreditmemoCommentRepositoryV1SaveResponse
    {
        
        private SalesDataCreditmemoCommentInterface resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public SalesDataCreditmemoCommentInterface result
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1")]
    public partial class SalesDataCreditmemoCommentInterface
    {
        
        private string commentField;
        
        private string createdAtField;
        
        private int entityIdField;
        
        private bool entityIdFieldSpecified;
        
        private int isCustomerNotifiedField;
        
        private int isVisibleOnFrontField;
        
        private int parentIdField;
        
        private SalesDataCreditmemoCommentExtensionInterface extensionAttributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string createdAt
        {
            get
            {
                return this.createdAtField;
            }
            set
            {
                this.createdAtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int entityId
        {
            get
            {
                return this.entityIdField;
            }
            set
            {
                this.entityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool entityIdSpecified
        {
            get
            {
                return this.entityIdFieldSpecified;
            }
            set
            {
                this.entityIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int isCustomerNotified
        {
            get
            {
                return this.isCustomerNotifiedField;
            }
            set
            {
                this.isCustomerNotifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int isVisibleOnFront
        {
            get
            {
                return this.isVisibleOnFrontField;
            }
            set
            {
                this.isVisibleOnFrontField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int parentId
        {
            get
            {
                return this.parentIdField;
            }
            set
            {
                this.parentIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public SalesDataCreditmemoCommentExtensionInterface extensionAttributes
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1")]
    public partial class SalesDataCreditmemoCommentExtensionInterface
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1")]
    public partial class SalesCreditmemoCommentRepositoryV1SaveRequest
    {
        
        private SalesDataCreditmemoCommentInterface entityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public SalesDataCreditmemoCommentInterface entity
        {
            get
            {
                return this.entityField;
            }
            set
            {
                this.entityField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
        "tRepositoryV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCo" +
        "mmentRepositoryV1.salesCreditmemoCommentRepositoryV1PortType")]
    public interface salesCreditmemoCommentRepositoryV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="salesCreditmemoCommentRepositoryV1Save", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.GenericFault), Action="salesCreditmemoCommentRepositoryV1Save", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1SaveResponse1> salesCreditmemoCommentRepositoryV1SaveAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1SaveRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class salesCreditmemoCommentRepositoryV1SaveRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
            "tRepositoryV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.SalesCreditmemoCommentRepositoryV1SaveRequest salesCreditmemoCommentRepositoryV1SaveRequest;
        
        public salesCreditmemoCommentRepositoryV1SaveRequest1()
        {
        }
        
        public salesCreditmemoCommentRepositoryV1SaveRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.SalesCreditmemoCommentRepositoryV1SaveRequest salesCreditmemoCommentRepositoryV1SaveRequest)
        {
            this.salesCreditmemoCommentRepositoryV1SaveRequest = salesCreditmemoCommentRepositoryV1SaveRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class salesCreditmemoCommentRepositoryV1SaveResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
            "tRepositoryV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.SalesCreditmemoCommentRepositoryV1SaveResponse salesCreditmemoCommentRepositoryV1SaveResponse;
        
        public salesCreditmemoCommentRepositoryV1SaveResponse1()
        {
        }
        
        public salesCreditmemoCommentRepositoryV1SaveResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.SalesCreditmemoCommentRepositoryV1SaveResponse salesCreditmemoCommentRepositoryV1SaveResponse)
        {
            this.salesCreditmemoCommentRepositoryV1SaveResponse = salesCreditmemoCommentRepositoryV1SaveResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface salesCreditmemoCommentRepositoryV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class salesCreditmemoCommentRepositoryV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public salesCreditmemoCommentRepositoryV1PortTypeClient() : 
                base(salesCreditmemoCommentRepositoryV1PortTypeClient.GetDefaultBinding(), salesCreditmemoCommentRepositoryV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.salesCreditmemoCommentRepositoryV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public salesCreditmemoCommentRepositoryV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(salesCreditmemoCommentRepositoryV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), salesCreditmemoCommentRepositoryV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public salesCreditmemoCommentRepositoryV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(salesCreditmemoCommentRepositoryV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public salesCreditmemoCommentRepositoryV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(salesCreditmemoCommentRepositoryV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public salesCreditmemoCommentRepositoryV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1SaveResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1PortType.salesCreditmemoCommentRepositoryV1SaveAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1SaveRequest1 request)
        {
            return base.Channel.salesCreditmemoCommentRepositoryV1SaveAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1SaveResponse1> salesCreditmemoCommentRepositoryV1SaveAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.SalesCreditmemoCommentRepositoryV1SaveRequest salesCreditmemoCommentRepositoryV1SaveRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1SaveRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1SaveRequest1();
            inValue.salesCreditmemoCommentRepositoryV1SaveRequest = salesCreditmemoCommentRepositoryV1SaveRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.SalesCreditmemoCommentRepositoryV1.salesCreditmemoCommentRepositoryV1PortType)(this)).salesCreditmemoCommentRepositoryV1SaveAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.salesCreditmemoCommentRepositoryV1Port))
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
            if ((endpointConfiguration == EndpointConfiguration.salesCreditmemoCommentRepositoryV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=salesCreditmemoCommen" +
                        "tRepositoryV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return salesCreditmemoCommentRepositoryV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.salesCreditmemoCommentRepositoryV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return salesCreditmemoCommentRepositoryV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.salesCreditmemoCommentRepositoryV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            salesCreditmemoCommentRepositoryV1Port,
        }
    }
}
