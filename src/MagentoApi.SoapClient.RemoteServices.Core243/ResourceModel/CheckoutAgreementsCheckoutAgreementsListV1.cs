//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class CheckoutAgreementsDataAgreementExtensionInterface
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class CheckoutAgreementsDataAgreementInterface
    {
        
        private int agreementIdField;
        
        private string nameField;
        
        private string contentField;
        
        private string contentHeightField;
        
        private string checkboxTextField;
        
        private bool isActiveField;
        
        private bool isHtmlField;
        
        private int modeField;
        
        private CheckoutAgreementsDataAgreementExtensionInterface extensionAttributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int agreementId
        {
            get
            {
                return this.agreementIdField;
            }
            set
            {
                this.agreementIdField = value;
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
        public string content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string contentHeight
        {
            get
            {
                return this.contentHeightField;
            }
            set
            {
                this.contentHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string checkboxText
        {
            get
            {
                return this.checkboxTextField;
            }
            set
            {
                this.checkboxTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool isActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool isHtml
        {
            get
            {
                return this.isHtmlField;
            }
            set
            {
                this.isHtmlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public CheckoutAgreementsDataAgreementExtensionInterface extensionAttributes
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class CheckoutAgreementsCheckoutAgreementsListV1GetListResponse
    {
        
        private CheckoutAgreementsDataAgreementInterface[] resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CheckoutAgreementsDataAgreementInterface[] result
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class FrameworkSortOrder
    {
        
        private string fieldField;
        
        private string directionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class FrameworkFilter
    {
        
        private string fieldField;
        
        private string valueField;
        
        private string conditionTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string conditionType
        {
            get
            {
                return this.conditionTypeField;
            }
            set
            {
                this.conditionTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class FrameworkSearchFilterGroup
    {
        
        private FrameworkFilter[] filtersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FrameworkFilter[] filters
        {
            get
            {
                return this.filtersField;
            }
            set
            {
                this.filtersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class FrameworkSearchCriteriaInterface
    {
        
        private FrameworkSearchFilterGroup[] filterGroupsField;
        
        private FrameworkSortOrder[] sortOrdersField;
        
        private int pageSizeField;
        
        private bool pageSizeFieldSpecified;
        
        private int currentPageField;
        
        private bool currentPageFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FrameworkSearchFilterGroup[] filterGroups
        {
            get
            {
                return this.filterGroupsField;
            }
            set
            {
                this.filterGroupsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FrameworkSortOrder[] sortOrders
        {
            get
            {
                return this.sortOrdersField;
            }
            set
            {
                this.sortOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int pageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified
        {
            get
            {
                return this.pageSizeFieldSpecified;
            }
            set
            {
                this.pageSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int currentPage
        {
            get
            {
                return this.currentPageField;
            }
            set
            {
                this.currentPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentPageSpecified
        {
            get
            {
                return this.currentPageFieldSpecified;
            }
            set
            {
                this.currentPageFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1")]
    public partial class CheckoutAgreementsCheckoutAgreementsListV1GetListRequest
    {
        
        private FrameworkSearchCriteriaInterface searchCriteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public FrameworkSearchCriteriaInterface searchCriteria
        {
            get
            {
                return this.searchCriteriaField;
            }
            set
            {
                this.searchCriteriaField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
        "ckoutAgreementsListV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreement" +
        "sCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1PortType")]
    public interface checkoutAgreementsCheckoutAgreementsListV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="checkoutAgreementsCheckoutAgreementsListV1GetList", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.GenericFault), Action="checkoutAgreementsCheckoutAgreementsListV1GetList", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1GetListResponse1> checkoutAgreementsCheckoutAgreementsListV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1GetListRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkoutAgreementsCheckoutAgreementsListV1GetListRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
            "ckoutAgreementsListV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.CheckoutAgreementsCheckoutAgreementsListV1GetListRequest checkoutAgreementsCheckoutAgreementsListV1GetListRequest;
        
        public checkoutAgreementsCheckoutAgreementsListV1GetListRequest1()
        {
        }
        
        public checkoutAgreementsCheckoutAgreementsListV1GetListRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.CheckoutAgreementsCheckoutAgreementsListV1GetListRequest checkoutAgreementsCheckoutAgreementsListV1GetListRequest)
        {
            this.checkoutAgreementsCheckoutAgreementsListV1GetListRequest = checkoutAgreementsCheckoutAgreementsListV1GetListRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkoutAgreementsCheckoutAgreementsListV1GetListResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
            "ckoutAgreementsListV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.CheckoutAgreementsCheckoutAgreementsListV1GetListResponse checkoutAgreementsCheckoutAgreementsListV1GetListResponse;
        
        public checkoutAgreementsCheckoutAgreementsListV1GetListResponse1()
        {
        }
        
        public checkoutAgreementsCheckoutAgreementsListV1GetListResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.CheckoutAgreementsCheckoutAgreementsListV1GetListResponse checkoutAgreementsCheckoutAgreementsListV1GetListResponse)
        {
            this.checkoutAgreementsCheckoutAgreementsListV1GetListResponse = checkoutAgreementsCheckoutAgreementsListV1GetListResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface checkoutAgreementsCheckoutAgreementsListV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class checkoutAgreementsCheckoutAgreementsListV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public checkoutAgreementsCheckoutAgreementsListV1PortTypeClient() : 
                base(checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetDefaultBinding(), checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.checkoutAgreementsCheckoutAgreementsListV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public checkoutAgreementsCheckoutAgreementsListV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public checkoutAgreementsCheckoutAgreementsListV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public checkoutAgreementsCheckoutAgreementsListV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public checkoutAgreementsCheckoutAgreementsListV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1GetListResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1PortType.checkoutAgreementsCheckoutAgreementsListV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1GetListRequest1 request)
        {
            return base.Channel.checkoutAgreementsCheckoutAgreementsListV1GetListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1GetListResponse1> checkoutAgreementsCheckoutAgreementsListV1GetListAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.CheckoutAgreementsCheckoutAgreementsListV1GetListRequest checkoutAgreementsCheckoutAgreementsListV1GetListRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1GetListRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1GetListRequest1();
            inValue.checkoutAgreementsCheckoutAgreementsListV1GetListRequest = checkoutAgreementsCheckoutAgreementsListV1GetListRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CheckoutAgreementsCheckoutAgreementsListV1.checkoutAgreementsCheckoutAgreementsListV1PortType)(this)).checkoutAgreementsCheckoutAgreementsListV1GetListAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.checkoutAgreementsCheckoutAgreementsListV1Port))
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
            if ((endpointConfiguration == EndpointConfiguration.checkoutAgreementsCheckoutAgreementsListV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=checkoutAgreementsChe" +
                        "ckoutAgreementsListV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.checkoutAgreementsCheckoutAgreementsListV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return checkoutAgreementsCheckoutAgreementsListV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.checkoutAgreementsCheckoutAgreementsListV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            checkoutAgreementsCheckoutAgreementsListV1Port,
        }
    }
}
