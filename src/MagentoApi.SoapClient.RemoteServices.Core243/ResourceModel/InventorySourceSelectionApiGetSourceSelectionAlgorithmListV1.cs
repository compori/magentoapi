//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1")]
    public partial class InventorySourceSelectionApiDataSourceSelectionAlgorithmExtensionInterface
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1")]
    public partial class InventorySourceSelectionApiDataSourceSelectionAlgorithmInterface
    {
        
        private string codeField;
        
        private string titleField;
        
        private string descriptionField;
        
        private InventorySourceSelectionApiDataSourceSelectionAlgorithmExtensionInterface extensionAttributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public InventorySourceSelectionApiDataSourceSelectionAlgorithmExtensionInterface extensionAttributes
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1")]
    public partial class InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse
    {
        
        private InventorySourceSelectionApiDataSourceSelectionAlgorithmInterface[] resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public InventorySourceSelectionApiDataSourceSelectionAlgorithmInterface[] result
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1")]
    public partial class InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
        "ionApiGetSourceSelectionAlgorithmListV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSe" +
        "lectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSource" +
        "SelectionAlgorithmListV1PortType")]
    public interface inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Execute", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.GenericFault), Action="inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Execute", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse1> inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
            "ionApiGetSourceSelectionAlgorithmListV1", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest;
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest1()
        {
        }
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest)
        {
            this.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest = inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
            "ionApiGetSourceSelectionAlgorithmListV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse;
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse1()
        {
        }
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse)
        {
            this.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse = inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient() : 
                base(inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetDefaultBinding(), inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortType.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest1 request)
        {
            return base.Channel.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteResponse1> inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest1();
            inValue.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest = inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventorySourceSelectionApiGetSourceSelectionAlgorithmListV1.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortType)(this)).inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1ExecuteAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Port))
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
            if ((endpointConfiguration == EndpointConfiguration.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=inventorySourceSelect" +
                        "ionApiGetSourceSelectionAlgorithmListV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            inventorySourceSelectionApiGetSourceSelectionAlgorithmListV1Port,
        }
    }
}
