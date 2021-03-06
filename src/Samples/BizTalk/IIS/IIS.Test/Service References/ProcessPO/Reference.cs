﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeploymentFramework.IIS.Test.ProcessPO {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://biztalkdeployment.codeplex.com/IISSample", ConfigurationName="ProcessPO.ProcessPOService")]
    internal interface ProcessPOService {
        
        // CODEGEN: Generating message contract since the operation ProcessPO is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="ProcessPO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        DeploymentFramework.IIS.Test.ProcessPO.ProcessPOResponse1 ProcessPO(DeploymentFramework.IIS.Test.ProcessPO.ProcessPORequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://IIS.WCFSchema")]
    public partial class ProcessPORequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private POType poField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://IIS.POSchema", Order=0)]
        public POType PO {
            get {
                return this.poField;
            }
            set {
                this.poField = value;
                this.RaisePropertyChanged("PO");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://IIS.POSchema")]
    public partial class POType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string pO_NumberField;
        
        private string totalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string PO_Number {
            get {
                return this.pO_NumberField;
            }
            set {
                this.pO_NumberField = value;
                this.RaisePropertyChanged("PO_Number");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
                this.RaisePropertyChanged("Total");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://IIS.InvoiceSchema")]
    public partial class InvoiceType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string numberField;
        
        private string totalPriceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
                this.RaisePropertyChanged("Number");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TotalPrice {
            get {
                return this.totalPriceField;
            }
            set {
                this.totalPriceField = value;
                this.RaisePropertyChanged("TotalPrice");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://IIS.WCFSchema")]
    public partial class ProcessPOResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private InvoiceType invoiceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://IIS.InvoiceSchema", Order=0)]
        public InvoiceType Invoice {
            get {
                return this.invoiceField;
            }
            set {
                this.invoiceField = value;
                this.RaisePropertyChanged("Invoice");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class ProcessPORequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://IIS.WCFSchema", Order=0)]
        public DeploymentFramework.IIS.Test.ProcessPO.ProcessPORequest ProcessPORequest;
        
        public ProcessPORequest1() {
        }
        
        public ProcessPORequest1(DeploymentFramework.IIS.Test.ProcessPO.ProcessPORequest ProcessPORequest) {
            this.ProcessPORequest = ProcessPORequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class ProcessPOResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://IIS.WCFSchema", Order=0)]
        public DeploymentFramework.IIS.Test.ProcessPO.ProcessPOResponse ProcessPOResponse;
        
        public ProcessPOResponse1() {
        }
        
        public ProcessPOResponse1(DeploymentFramework.IIS.Test.ProcessPO.ProcessPOResponse ProcessPOResponse) {
            this.ProcessPOResponse = ProcessPOResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface ProcessPOServiceChannel : DeploymentFramework.IIS.Test.ProcessPO.ProcessPOService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class ProcessPOServiceClient : System.ServiceModel.ClientBase<DeploymentFramework.IIS.Test.ProcessPO.ProcessPOService>, DeploymentFramework.IIS.Test.ProcessPO.ProcessPOService {
        
        public ProcessPOServiceClient() {
        }
        
        public ProcessPOServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProcessPOServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProcessPOServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProcessPOServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DeploymentFramework.IIS.Test.ProcessPO.ProcessPOResponse1 DeploymentFramework.IIS.Test.ProcessPO.ProcessPOService.ProcessPO(DeploymentFramework.IIS.Test.ProcessPO.ProcessPORequest1 request) {
            return base.Channel.ProcessPO(request);
        }
        
        public DeploymentFramework.IIS.Test.ProcessPO.ProcessPOResponse ProcessPO(DeploymentFramework.IIS.Test.ProcessPO.ProcessPORequest ProcessPORequest) {
            DeploymentFramework.IIS.Test.ProcessPO.ProcessPORequest1 inValue = new DeploymentFramework.IIS.Test.ProcessPO.ProcessPORequest1();
            inValue.ProcessPORequest = ProcessPORequest;
            DeploymentFramework.IIS.Test.ProcessPO.ProcessPOResponse1 retVal = ((DeploymentFramework.IIS.Test.ProcessPO.ProcessPOService)(this)).ProcessPO(inValue);
            return retVal.ProcessPOResponse;
        }
    }
}
