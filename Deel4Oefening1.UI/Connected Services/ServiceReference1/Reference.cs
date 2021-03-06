﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Deel4Oefening1.UI.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Boete", Namespace="http://schemas.datacontract.org/2004/07/Deel4Oefening1.Service")]
    [System.SerializableAttribute()]
    public partial class Boete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BedragField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BetalingsnrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SpelersnrField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Bedrag {
            get {
                return this.BedragField;
            }
            set {
                if ((this.BedragField.Equals(value) != true)) {
                    this.BedragField = value;
                    this.RaisePropertyChanged("Bedrag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Betalingsnr {
            get {
                return this.BetalingsnrField;
            }
            set {
                if ((this.BetalingsnrField.Equals(value) != true)) {
                    this.BetalingsnrField = value;
                    this.RaisePropertyChanged("Betalingsnr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Datum {
            get {
                return this.DatumField;
            }
            set {
                if ((this.DatumField.Equals(value) != true)) {
                    this.DatumField = value;
                    this.RaisePropertyChanged("Datum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Spelersnr {
            get {
                return this.SpelersnrField;
            }
            set {
                if ((this.SpelersnrField.Equals(value) != true)) {
                    this.SpelersnrField = value;
                    this.RaisePropertyChanged("Spelersnr");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBoetes", ReplyAction="http://tempuri.org/IService1/GetBoetesResponse")]
        Deel4Oefening1.UI.ServiceReference1.Boete[] GetBoetes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBoetes", ReplyAction="http://tempuri.org/IService1/GetBoetesResponse")]
        System.Threading.Tasks.Task<Deel4Oefening1.UI.ServiceReference1.Boete[]> GetBoetesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBoete", ReplyAction="http://tempuri.org/IService1/AddBoeteResponse")]
        void AddBoete(int betalingsnr, int spelersnr, System.DateTime datum, decimal bedrag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBoete", ReplyAction="http://tempuri.org/IService1/AddBoeteResponse")]
        System.Threading.Tasks.Task AddBoeteAsync(int betalingsnr, int spelersnr, System.DateTime datum, decimal bedrag);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Deel4Oefening1.UI.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Deel4Oefening1.UI.ServiceReference1.IService1>, Deel4Oefening1.UI.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Deel4Oefening1.UI.ServiceReference1.Boete[] GetBoetes() {
            return base.Channel.GetBoetes();
        }
        
        public System.Threading.Tasks.Task<Deel4Oefening1.UI.ServiceReference1.Boete[]> GetBoetesAsync() {
            return base.Channel.GetBoetesAsync();
        }
        
        public void AddBoete(int betalingsnr, int spelersnr, System.DateTime datum, decimal bedrag) {
            base.Channel.AddBoete(betalingsnr, spelersnr, datum, bedrag);
        }
        
        public System.Threading.Tasks.Task AddBoeteAsync(int betalingsnr, int spelersnr, System.DateTime datum, decimal bedrag) {
            return base.Channel.AddBoeteAsync(betalingsnr, spelersnr, datum, bedrag);
        }
    }
}
