﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace example.Summator {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Summator")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long IDk__BackingFieldField;
        
        private string Logink__BackingFieldField;
        
        private string Passwordk__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ID>k__BackingField", IsRequired=true)]
        public long IDk__BackingField {
            get {
                return this.IDk__BackingFieldField;
            }
            set {
                if ((this.IDk__BackingFieldField.Equals(value) != true)) {
                    this.IDk__BackingFieldField = value;
                    this.RaisePropertyChanged("IDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Login>k__BackingField", IsRequired=true)]
        public string Logink__BackingField {
            get {
                return this.Logink__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Logink__BackingFieldField, value) != true)) {
                    this.Logink__BackingFieldField = value;
                    this.RaisePropertyChanged("Logink__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Password>k__BackingField", IsRequired=true)]
        public string Passwordk__BackingField {
            get {
                return this.Passwordk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Passwordk__BackingFieldField, value) != true)) {
                    this.Passwordk__BackingFieldField = value;
                    this.RaisePropertyChanged("Passwordk__BackingField");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Summator.ISummator")]
    public interface ISummator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/GetUsers", ReplyAction="http://tempuri.org/ISummator/GetUsersResponse")]
        example.Summator.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/GetUsers", ReplyAction="http://tempuri.org/ISummator/GetUsersResponse")]
        System.Threading.Tasks.Task<example.Summator.User[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/AddToDb", ReplyAction="http://tempuri.org/ISummator/AddToDbResponse")]
        int AddToDb(string login, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/AddToDb", ReplyAction="http://tempuri.org/ISummator/AddToDbResponse")]
        System.Threading.Tasks.Task<int> AddToDbAsync(string login, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/CheckUser", ReplyAction="http://tempuri.org/ISummator/CheckUserResponse")]
        int CheckUser(string login, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/CheckUser", ReplyAction="http://tempuri.org/ISummator/CheckUserResponse")]
        System.Threading.Tasks.Task<int> CheckUserAsync(string login, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/SaveUser", ReplyAction="http://tempuri.org/ISummator/SaveUserResponse")]
        int SaveUser(example.Summator.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/SaveUser", ReplyAction="http://tempuri.org/ISummator/SaveUserResponse")]
        System.Threading.Tasks.Task<int> SaveUserAsync(example.Summator.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/ValidateUser", ReplyAction="http://tempuri.org/ISummator/ValidateUserResponse")]
        bool ValidateUser(example.Summator.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/ValidateUser", ReplyAction="http://tempuri.org/ISummator/ValidateUserResponse")]
        System.Threading.Tasks.Task<bool> ValidateUserAsync(example.Summator.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISummatorChannel : example.Summator.ISummator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SummatorClient : System.ServiceModel.ClientBase<example.Summator.ISummator>, example.Summator.ISummator {
        
        public SummatorClient() {
        }
        
        public SummatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SummatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public example.Summator.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<example.Summator.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public int AddToDb(string login, string pass) {
            return base.Channel.AddToDb(login, pass);
        }
        
        public System.Threading.Tasks.Task<int> AddToDbAsync(string login, string pass) {
            return base.Channel.AddToDbAsync(login, pass);
        }
        
        public int CheckUser(string login, string pass) {
            return base.Channel.CheckUser(login, pass);
        }
        
        public System.Threading.Tasks.Task<int> CheckUserAsync(string login, string pass) {
            return base.Channel.CheckUserAsync(login, pass);
        }
        
        public int SaveUser(example.Summator.User user) {
            return base.Channel.SaveUser(user);
        }
        
        public System.Threading.Tasks.Task<int> SaveUserAsync(example.Summator.User user) {
            return base.Channel.SaveUserAsync(user);
        }
        
        public bool ValidateUser(example.Summator.User user) {
            return base.Channel.ValidateUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateUserAsync(example.Summator.User user) {
            return base.Channel.ValidateUserAsync(user);
        }
    }
}
