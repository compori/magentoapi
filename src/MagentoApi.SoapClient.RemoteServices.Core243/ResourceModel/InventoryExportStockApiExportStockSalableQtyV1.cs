﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
    public partial class FrameworkExtensibleDataInterface
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
    public partial class InventoryExportStockApiDataExportStockSalableQtySearchResultInterface
    {
        
        private FrameworkExtensibleDataInterface[] itemsField;
        
        private FrameworkSearchCriteriaInterface searchCriteriaField;
        
        private int totalCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FrameworkExtensibleDataInterface[] items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int totalCount
        {
            get
            {
                return this.totalCountField;
            }
            set
            {
                this.totalCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
    public partial class InventoryExportStockApiExportStockSalableQtyV1ExecuteResponse
    {
        
        private InventoryExportStockApiDataExportStockSalableQtySearchResultInterface resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InventoryExportStockApiDataExportStockSalableQtySearchResultInterface result
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1")]
    public partial class InventoryExportStockApiExportStockSalableQtyV1ExecuteRequest
    {
        
        private string salesChannelTypeField;
        
        private string salesChannelCodeField;
        
        private FrameworkSearchCriteriaInterface searchCriteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string salesChannelType
        {
            get
            {
                return this.salesChannelTypeField;
            }
            set
            {
                this.salesChannelTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string salesChannelCode
        {
            get
            {
                return this.salesChannelCodeField;
            }
            set
            {
                this.salesChannelCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
        "piExportStockSalableQtyV1", ConfigurationName="Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportSt" +
        "ockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1Port" +
        "Type")]
    public interface inventoryExportStockApiExportStockSalableQtyV1PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="inventoryExportStockApiExportStockSalableQtyV1Execute", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.GenericFault), Action="inventoryExportStockApiExportStockSalableQtyV1Execute", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse1> inventoryExportStockApiExportStockSalableQtyV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
            "piExportStockSalableQtyV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.InventoryExportStockApiExportStockSalableQtyV1ExecuteRequest inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest;
        
        public inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest1()
        {
        }
        
        public inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.InventoryExportStockApiExportStockSalableQtyV1ExecuteRequest inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest)
        {
            this.inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest = inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
            "piExportStockSalableQtyV1", Order=0)]
        public Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.InventoryExportStockApiExportStockSalableQtyV1ExecuteResponse inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse;
        
        public inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse1()
        {
        }
        
        public inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse1(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.InventoryExportStockApiExportStockSalableQtyV1ExecuteResponse inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse)
        {
            this.inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse = inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface inventoryExportStockApiExportStockSalableQtyV1PortTypeChannel : Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class inventoryExportStockApiExportStockSalableQtyV1PortTypeClient : System.ServiceModel.ClientBase<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1PortType>, Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1PortType
    {
        
        /// <summary>
        /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
        /// </summary>
        /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
        /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public inventoryExportStockApiExportStockSalableQtyV1PortTypeClient() : 
                base(inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetDefaultBinding(), inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.inventoryExportStockApiExportStockSalableQtyV1Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventoryExportStockApiExportStockSalableQtyV1PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventoryExportStockApiExportStockSalableQtyV1PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventoryExportStockApiExportStockSalableQtyV1PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public inventoryExportStockApiExportStockSalableQtyV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse1> Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1PortType.inventoryExportStockApiExportStockSalableQtyV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest1 request)
        {
            return base.Channel.inventoryExportStockApiExportStockSalableQtyV1ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1ExecuteResponse1> inventoryExportStockApiExportStockSalableQtyV1ExecuteAsync(Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.InventoryExportStockApiExportStockSalableQtyV1ExecuteRequest inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest)
        {
            Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest1 inValue = new Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest1();
            inValue.inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest = inventoryExportStockApiExportStockSalableQtyV1ExecuteRequest;
            return ((Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.InventoryExportStockApiExportStockSalableQtyV1.inventoryExportStockApiExportStockSalableQtyV1PortType)(this)).inventoryExportStockApiExportStockSalableQtyV1ExecuteAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.inventoryExportStockApiExportStockSalableQtyV1Port))
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
            if ((endpointConfiguration == EndpointConfiguration.inventoryExportStockApiExportStockSalableQtyV1Port))
            {
                return new System.ServiceModel.EndpointAddress("http://connector.monnier.cidev04.test/soap/default?services=inventoryExportStockA" +
                        "piExportStockSalableQtyV1");
            }
            throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.inventoryExportStockApiExportStockSalableQtyV1Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return inventoryExportStockApiExportStockSalableQtyV1PortTypeClient.GetEndpointAddress(EndpointConfiguration.inventoryExportStockApiExportStockSalableQtyV1Port);
        }
        
        public enum EndpointConfiguration
        {
            
            inventoryExportStockApiExportStockSalableQtyV1Port,
        }
    }
}
