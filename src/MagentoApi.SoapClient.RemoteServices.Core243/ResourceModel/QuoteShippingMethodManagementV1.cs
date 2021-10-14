﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
    public partial class QuoteDataShippingMethodExtensionInterface
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
    public partial class QuoteShippingMethodManagementV1GetListResponse
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
    public partial class QuoteShippingMethodManagementV1GetListRequest
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMeth" +
        "odManagementV1.quoteShippingMethodManagementV1PortType")]
    public interface quoteShippingMethodManagementV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="quoteShippingMethodManagementV1GetList", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.GenericFault), Action="quoteShippingMethodManagementV1GetList", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1GetListResponse1> quoteShippingMethodManagementV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1GetListRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="quoteShippingMethodManagementV1EstimateByAddressId", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.GenericFault), Action="quoteShippingMethodManagementV1EstimateByAddressId", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1EstimateByAddressIdResponse1> quoteShippingMethodManagementV1EstimateByAddressIdAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1EstimateByAddressIdRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class quoteShippingMethodManagementV1GetListRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
            "nagementV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1GetListRequest quoteShippingMethodManagementV1GetListRequest;
        
        public quoteShippingMethodManagementV1GetListRequest1()
        {
        }
        
        public quoteShippingMethodManagementV1GetListRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1GetListRequest quoteShippingMethodManagementV1GetListRequest)
        {
            this.quoteShippingMethodManagementV1GetListRequest = quoteShippingMethodManagementV1GetListRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class quoteShippingMethodManagementV1GetListResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
            "nagementV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1GetListResponse quoteShippingMethodManagementV1GetListResponse;
        
        public quoteShippingMethodManagementV1GetListResponse1()
        {
        }
        
        public quoteShippingMethodManagementV1GetListResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1GetListResponse quoteShippingMethodManagementV1GetListResponse)
        {
            this.quoteShippingMethodManagementV1GetListResponse = quoteShippingMethodManagementV1GetListResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
    public partial class QuoteShippingMethodManagementV1EstimateByAddressIdRequest
    {
        
        private int cartIdField;
        
        private int addressIdField;
        
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
        public int addressId
        {
            get
            {
                return this.addressIdField;
            }
            set
            {
                this.addressIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
        "nagementV1")]
    public partial class QuoteShippingMethodManagementV1EstimateByAddressIdResponse
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class quoteShippingMethodManagementV1EstimateByAddressIdRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
            "nagementV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1EstimateByAddressIdRequest quoteShippingMethodManagementV1EstimateByAddressIdRequest;
        
        public quoteShippingMethodManagementV1EstimateByAddressIdRequest1()
        {
        }
        
        public quoteShippingMethodManagementV1EstimateByAddressIdRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1EstimateByAddressIdRequest quoteShippingMethodManagementV1EstimateByAddressIdRequest)
        {
            this.quoteShippingMethodManagementV1EstimateByAddressIdRequest = quoteShippingMethodManagementV1EstimateByAddressIdRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class quoteShippingMethodManagementV1EstimateByAddressIdResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
            "nagementV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1EstimateByAddressIdResponse quoteShippingMethodManagementV1EstimateByAddressIdResponse;
        
        public quoteShippingMethodManagementV1EstimateByAddressIdResponse1()
        {
        }
        
        public quoteShippingMethodManagementV1EstimateByAddressIdResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1EstimateByAddressIdResponse quoteShippingMethodManagementV1EstimateByAddressIdResponse)
        {
            this.quoteShippingMethodManagementV1EstimateByAddressIdResponse = quoteShippingMethodManagementV1EstimateByAddressIdResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface quoteShippingMethodManagementV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class quoteShippingMethodManagementV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public quoteShippingMethodManagementV1PortTypeClient() : 
                base(quoteShippingMethodManagementV1PortTypeClient.GetDefaultBinding(), quoteShippingMethodManagementV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.quoteShippingMethodManagementV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteShippingMethodManagementV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(quoteShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), quoteShippingMethodManagementV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteShippingMethodManagementV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(quoteShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteShippingMethodManagementV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(quoteShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public quoteShippingMethodManagementV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1GetListResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1PortType.quoteShippingMethodManagementV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1GetListRequest1 request)
        {
            return base.Channel.quoteShippingMethodManagementV1GetListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1GetListResponse1> quoteShippingMethodManagementV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1GetListRequest quoteShippingMethodManagementV1GetListRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1GetListRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1GetListRequest1();
            inValue.quoteShippingMethodManagementV1GetListRequest = quoteShippingMethodManagementV1GetListRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1PortType)(this)).quoteShippingMethodManagementV1GetListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1EstimateByAddressIdResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1PortType.quoteShippingMethodManagementV1EstimateByAddressIdAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1EstimateByAddressIdRequest1 request)
        {
            return base.Channel.quoteShippingMethodManagementV1EstimateByAddressIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1EstimateByAddressIdResponse1> quoteShippingMethodManagementV1EstimateByAddressIdAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.QuoteShippingMethodManagementV1EstimateByAddressIdRequest quoteShippingMethodManagementV1EstimateByAddressIdRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1EstimateByAddressIdRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1EstimateByAddressIdRequest1();
            inValue.quoteShippingMethodManagementV1EstimateByAddressIdRequest = quoteShippingMethodManagementV1EstimateByAddressIdRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.QuoteShippingMethodManagementV1.quoteShippingMethodManagementV1PortType)(this)).quoteShippingMethodManagementV1EstimateByAddressIdAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.quoteShippingMethodManagementV1Port))
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
            if ((endpointConfiguration == EndpointConfiguration.quoteShippingMethodManagementV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=quoteShippingMethodMa" +
                        "nagementV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return quoteShippingMethodManagementV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.quoteShippingMethodManagementV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return quoteShippingMethodManagementV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.quoteShippingMethodManagementV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            quoteShippingMethodManagementV1Port,
        }
    }
}
