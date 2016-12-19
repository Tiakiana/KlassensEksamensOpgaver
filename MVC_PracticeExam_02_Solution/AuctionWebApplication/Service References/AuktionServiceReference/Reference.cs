﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuctionWebApplication.AuktionServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuctionItem", Namespace="http://schemas.datacontract.org/2004/07/WCF_AuctionWebApplication")]
    [System.SerializableAttribute()]
    public partial class AuctionItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BidCustomNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BidCustomPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BidPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BidTimestampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RatingPriceField;
        
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
        public string BidCustomName {
            get {
                return this.BidCustomNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BidCustomNameField, value) != true)) {
                    this.BidCustomNameField = value;
                    this.RaisePropertyChanged("BidCustomName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BidCustomPhone {
            get {
                return this.BidCustomPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.BidCustomPhoneField, value) != true)) {
                    this.BidCustomPhoneField = value;
                    this.RaisePropertyChanged("BidCustomPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BidPrice {
            get {
                return this.BidPriceField;
            }
            set {
                if ((this.BidPriceField.Equals(value) != true)) {
                    this.BidPriceField = value;
                    this.RaisePropertyChanged("BidPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BidTimestamp {
            get {
                return this.BidTimestampField;
            }
            set {
                if ((this.BidTimestampField.Equals(value) != true)) {
                    this.BidTimestampField = value;
                    this.RaisePropertyChanged("BidTimestamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemDescription {
            get {
                return this.ItemDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemDescriptionField, value) != true)) {
                    this.ItemDescriptionField = value;
                    this.RaisePropertyChanged("ItemDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemNumber {
            get {
                return this.ItemNumberField;
            }
            set {
                if ((this.ItemNumberField.Equals(value) != true)) {
                    this.ItemNumberField = value;
                    this.RaisePropertyChanged("ItemNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RatingPrice {
            get {
                return this.RatingPriceField;
            }
            set {
                if ((this.RatingPriceField.Equals(value) != true)) {
                    this.RatingPriceField = value;
                    this.RaisePropertyChanged("RatingPrice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuktionServiceReference.IAuctionsService")]
    public interface IAuctionsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/GetAllAuctionItems", ReplyAction="http://tempuri.org/IAuctionsService/GetAllAuctionItemsResponse")]
        AuctionWebApplication.AuktionServiceReference.AuctionItem[] GetAllAuctionItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/GetAllAuctionItems", ReplyAction="http://tempuri.org/IAuctionsService/GetAllAuctionItemsResponse")]
        System.Threading.Tasks.Task<AuctionWebApplication.AuktionServiceReference.AuctionItem[]> GetAllAuctionItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/GetAuctionItem", ReplyAction="http://tempuri.org/IAuctionsService/GetAuctionItemResponse")]
        AuctionWebApplication.AuktionServiceReference.AuctionItem GetAuctionItem(int itemNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/GetAuctionItem", ReplyAction="http://tempuri.org/IAuctionsService/GetAuctionItemResponse")]
        System.Threading.Tasks.Task<AuctionWebApplication.AuktionServiceReference.AuctionItem> GetAuctionItemAsync(int itemNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/CreateAuctionItem", ReplyAction="http://tempuri.org/IAuctionsService/CreateAuctionItemResponse")]
        string CreateAuctionItem(int itemNumber, string idemDescription, int ratingPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/CreateAuctionItem", ReplyAction="http://tempuri.org/IAuctionsService/CreateAuctionItemResponse")]
        System.Threading.Tasks.Task<string> CreateAuctionItemAsync(int itemNumber, string idemDescription, int ratingPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/ProvideBid", ReplyAction="http://tempuri.org/IAuctionsService/ProvideBidResponse")]
        string ProvideBid(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionsService/ProvideBid", ReplyAction="http://tempuri.org/IAuctionsService/ProvideBidResponse")]
        System.Threading.Tasks.Task<string> ProvideBidAsync(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuctionsServiceChannel : AuctionWebApplication.AuktionServiceReference.IAuctionsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuctionsServiceClient : System.ServiceModel.ClientBase<AuctionWebApplication.AuktionServiceReference.IAuctionsService>, AuctionWebApplication.AuktionServiceReference.IAuctionsService {
        
        public AuctionsServiceClient() {
        }
        
        public AuctionsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuctionsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AuctionWebApplication.AuktionServiceReference.AuctionItem[] GetAllAuctionItems() {
            return base.Channel.GetAllAuctionItems();
        }
        
        public System.Threading.Tasks.Task<AuctionWebApplication.AuktionServiceReference.AuctionItem[]> GetAllAuctionItemsAsync() {
            return base.Channel.GetAllAuctionItemsAsync();
        }
        
        public AuctionWebApplication.AuktionServiceReference.AuctionItem GetAuctionItem(int itemNumber) {
            return base.Channel.GetAuctionItem(itemNumber);
        }
        
        public System.Threading.Tasks.Task<AuctionWebApplication.AuktionServiceReference.AuctionItem> GetAuctionItemAsync(int itemNumber) {
            return base.Channel.GetAuctionItemAsync(itemNumber);
        }
        
        public string CreateAuctionItem(int itemNumber, string idemDescription, int ratingPrice) {
            return base.Channel.CreateAuctionItem(itemNumber, idemDescription, ratingPrice);
        }
        
        public System.Threading.Tasks.Task<string> CreateAuctionItemAsync(int itemNumber, string idemDescription, int ratingPrice) {
            return base.Channel.CreateAuctionItemAsync(itemNumber, idemDescription, ratingPrice);
        }
        
        public string ProvideBid(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone) {
            return base.Channel.ProvideBid(itemNumber, bidPrice, bidCustomName, bidCustomPhone);
        }
        
        public System.Threading.Tasks.Task<string> ProvideBidAsync(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone) {
            return base.Channel.ProvideBidAsync(itemNumber, bidPrice, bidCustomName, bidCustomPhone);
        }
    }
}
