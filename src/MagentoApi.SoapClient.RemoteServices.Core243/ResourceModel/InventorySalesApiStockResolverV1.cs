﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
    public partial class InventorySalesApiDataSalesChannelExtensionInterface
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
    public partial class InventorySalesApiDataSalesChannelInterface
    {
        
        private string typeField;
        
        private string codeField;
        
        private InventorySalesApiDataSalesChannelExtensionInterface extensionAttributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public InventorySalesApiDataSalesChannelExtensionInterface extensionAttributes
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
    public partial class InventoryApiDataStockExtensionInterface
    {
        
        private InventorySalesApiDataSalesChannelInterface[] salesChannelsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public InventorySalesApiDataSalesChannelInterface[] salesChannels
        {
            get
            {
                return this.salesChannelsField;
            }
            set
            {
                this.salesChannelsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
    public partial class InventoryApiDataStockInterface
    {
        
        private int stockIdField;
        
        private bool stockIdFieldSpecified;
        
        private string nameField;
        
        private InventoryApiDataStockExtensionInterface extensionAttributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int stockId
        {
            get
            {
                return this.stockIdField;
            }
            set
            {
                this.stockIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stockIdSpecified
        {
            get
            {
                return this.stockIdFieldSpecified;
            }
            set
            {
                this.stockIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public InventoryApiDataStockExtensionInterface extensionAttributes
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
    public partial class InventorySalesApiStockResolverV1ExecuteResponse
    {
        
        private InventoryApiDataStockInterface resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InventoryApiDataStockInterface result
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1")]
    public partial class InventorySalesApiStockResolverV1ExecuteRequest
    {
        
        private string typeField;
        
        private string codeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
        "kResolverV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApi" +
        "StockResolverV1.inventorySalesApiStockResolverV1PortType")]
    public interface inventorySalesApiStockResolverV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="inventorySalesApiStockResolverV1Execute", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.GenericFault), Action="inventorySalesApiStockResolverV1Execute", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1ExecuteResponse1> inventorySalesApiStockResolverV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1ExecuteRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class inventorySalesApiStockResolverV1ExecuteRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
            "kResolverV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.InventorySalesApiStockResolverV1ExecuteRequest inventorySalesApiStockResolverV1ExecuteRequest;
        
        public inventorySalesApiStockResolverV1ExecuteRequest1()
        {
        }
        
        public inventorySalesApiStockResolverV1ExecuteRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.InventorySalesApiStockResolverV1ExecuteRequest inventorySalesApiStockResolverV1ExecuteRequest)
        {
            this.inventorySalesApiStockResolverV1ExecuteRequest = inventorySalesApiStockResolverV1ExecuteRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class inventorySalesApiStockResolverV1ExecuteResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
            "kResolverV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.InventorySalesApiStockResolverV1ExecuteResponse inventorySalesApiStockResolverV1ExecuteResponse;
        
        public inventorySalesApiStockResolverV1ExecuteResponse1()
        {
        }
        
        public inventorySalesApiStockResolverV1ExecuteResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.InventorySalesApiStockResolverV1ExecuteResponse inventorySalesApiStockResolverV1ExecuteResponse)
        {
            this.inventorySalesApiStockResolverV1ExecuteResponse = inventorySalesApiStockResolverV1ExecuteResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface inventorySalesApiStockResolverV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class inventorySalesApiStockResolverV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public inventorySalesApiStockResolverV1PortTypeClient() : 
                base(inventorySalesApiStockResolverV1PortTypeClient.GetDefaultBinding(), inventorySalesApiStockResolverV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.inventorySalesApiStockResolverV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySalesApiStockResolverV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(inventorySalesApiStockResolverV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), inventorySalesApiStockResolverV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySalesApiStockResolverV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(inventorySalesApiStockResolverV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySalesApiStockResolverV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(inventorySalesApiStockResolverV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySalesApiStockResolverV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1ExecuteResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1PortType.inventorySalesApiStockResolverV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1ExecuteRequest1 request)
        {
            return base.Channel.inventorySalesApiStockResolverV1ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1ExecuteResponse1> inventorySalesApiStockResolverV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.InventorySalesApiStockResolverV1ExecuteRequest inventorySalesApiStockResolverV1ExecuteRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1ExecuteRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1ExecuteRequest1();
            inValue.inventorySalesApiStockResolverV1ExecuteRequest = inventorySalesApiStockResolverV1ExecuteRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySalesApiStockResolverV1.inventorySalesApiStockResolverV1PortType)(this)).inventorySalesApiStockResolverV1ExecuteAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.inventorySalesApiStockResolverV1Port))
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
            if ((endpointConfiguration == EndpointConfiguration.inventorySalesApiStockResolverV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=inventorySalesApiStoc" +
                        "kResolverV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return inventorySalesApiStockResolverV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.inventorySalesApiStockResolverV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return inventorySalesApiStockResolverV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.inventorySalesApiStockResolverV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            inventorySalesApiStockResolverV1Port,
        }
    }
}