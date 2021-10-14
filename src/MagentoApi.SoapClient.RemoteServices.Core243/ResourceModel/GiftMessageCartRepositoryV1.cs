﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
    public partial class GiftMessageDataMessageExtensionInterface
    {
        
        private string entityIdField;
        
        private string entityTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string entityId
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string entityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
    public partial class GiftMessageDataMessageInterface
    {
        
        private int giftMessageIdField;
        
        private bool giftMessageIdFieldSpecified;
        
        private int customerIdField;
        
        private bool customerIdFieldSpecified;
        
        private string senderField;
        
        private string recipientField;
        
        private string messageField;
        
        private GiftMessageDataMessageExtensionInterface extensionAttributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int giftMessageId
        {
            get
            {
                return this.giftMessageIdField;
            }
            set
            {
                this.giftMessageIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giftMessageIdSpecified
        {
            get
            {
                return this.giftMessageIdFieldSpecified;
            }
            set
            {
                this.giftMessageIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int customerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool customerIdSpecified
        {
            get
            {
                return this.customerIdFieldSpecified;
            }
            set
            {
                this.customerIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public GiftMessageDataMessageExtensionInterface extensionAttributes
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
    public partial class GiftMessageCartRepositoryV1GetResponse
    {
        
        private GiftMessageDataMessageInterface resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public GiftMessageDataMessageInterface result
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
    public partial class GiftMessageCartRepositoryV1GetRequest
    {
        
        private int cartIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int cartId
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRe" +
        "positoryV1.giftMessageCartRepositoryV1PortType")]
    public interface giftMessageCartRepositoryV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="giftMessageCartRepositoryV1Get", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GenericFault), Action="giftMessageCartRepositoryV1Get", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1GetResponse1> giftMessageCartRepositoryV1GetAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1GetRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="giftMessageCartRepositoryV1Save", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GenericFault), Action="giftMessageCartRepositoryV1Save", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1SaveResponse1> giftMessageCartRepositoryV1SaveAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1SaveRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class giftMessageCartRepositoryV1GetRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
            "toryV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1GetRequest giftMessageCartRepositoryV1GetRequest;
        
        public giftMessageCartRepositoryV1GetRequest1()
        {
        }
        
        public giftMessageCartRepositoryV1GetRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1GetRequest giftMessageCartRepositoryV1GetRequest)
        {
            this.giftMessageCartRepositoryV1GetRequest = giftMessageCartRepositoryV1GetRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class giftMessageCartRepositoryV1GetResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
            "toryV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1GetResponse giftMessageCartRepositoryV1GetResponse;
        
        public giftMessageCartRepositoryV1GetResponse1()
        {
        }
        
        public giftMessageCartRepositoryV1GetResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1GetResponse giftMessageCartRepositoryV1GetResponse)
        {
            this.giftMessageCartRepositoryV1GetResponse = giftMessageCartRepositoryV1GetResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
    public partial class GiftMessageCartRepositoryV1SaveRequest
    {
        
        private int cartIdField;
        
        private GiftMessageDataMessageInterface giftMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int cartId
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public GiftMessageDataMessageInterface giftMessage
        {
            get
            {
                return this.giftMessageField;
            }
            set
            {
                this.giftMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
        "toryV1")]
    public partial class GiftMessageCartRepositoryV1SaveResponse
    {
        
        private bool resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool result
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class giftMessageCartRepositoryV1SaveRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
            "toryV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1SaveRequest giftMessageCartRepositoryV1SaveRequest;
        
        public giftMessageCartRepositoryV1SaveRequest1()
        {
        }
        
        public giftMessageCartRepositoryV1SaveRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1SaveRequest giftMessageCartRepositoryV1SaveRequest)
        {
            this.giftMessageCartRepositoryV1SaveRequest = giftMessageCartRepositoryV1SaveRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class giftMessageCartRepositoryV1SaveResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
            "toryV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1SaveResponse giftMessageCartRepositoryV1SaveResponse;
        
        public giftMessageCartRepositoryV1SaveResponse1()
        {
        }
        
        public giftMessageCartRepositoryV1SaveResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1SaveResponse giftMessageCartRepositoryV1SaveResponse)
        {
            this.giftMessageCartRepositoryV1SaveResponse = giftMessageCartRepositoryV1SaveResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface giftMessageCartRepositoryV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class giftMessageCartRepositoryV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public giftMessageCartRepositoryV1PortTypeClient() : 
                base(giftMessageCartRepositoryV1PortTypeClient.GetDefaultBinding(), giftMessageCartRepositoryV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.giftMessageCartRepositoryV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public giftMessageCartRepositoryV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(giftMessageCartRepositoryV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), giftMessageCartRepositoryV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public giftMessageCartRepositoryV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(giftMessageCartRepositoryV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public giftMessageCartRepositoryV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(giftMessageCartRepositoryV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public giftMessageCartRepositoryV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1GetResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1PortType.giftMessageCartRepositoryV1GetAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1GetRequest1 request)
        {
            return base.Channel.giftMessageCartRepositoryV1GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1GetResponse1> giftMessageCartRepositoryV1GetAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1GetRequest giftMessageCartRepositoryV1GetRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1GetRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1GetRequest1();
            inValue.giftMessageCartRepositoryV1GetRequest = giftMessageCartRepositoryV1GetRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1PortType)(this)).giftMessageCartRepositoryV1GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1SaveResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1PortType.giftMessageCartRepositoryV1SaveAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1SaveRequest1 request)
        {
            return base.Channel.giftMessageCartRepositoryV1SaveAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1SaveResponse1> giftMessageCartRepositoryV1SaveAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.GiftMessageCartRepositoryV1SaveRequest giftMessageCartRepositoryV1SaveRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1SaveRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1SaveRequest1();
            inValue.giftMessageCartRepositoryV1SaveRequest = giftMessageCartRepositoryV1SaveRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.GiftMessageCartRepositoryV1.giftMessageCartRepositoryV1PortType)(this)).giftMessageCartRepositoryV1SaveAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.giftMessageCartRepositoryV1Port))
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
            if ((endpointConfiguration == EndpointConfiguration.giftMessageCartRepositoryV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=giftMessageCartReposi" +
                        "toryV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return giftMessageCartRepositoryV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.giftMessageCartRepositoryV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return giftMessageCartRepositoryV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.giftMessageCartRepositoryV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            giftMessageCartRepositoryV1Port,
        }
    }
}
