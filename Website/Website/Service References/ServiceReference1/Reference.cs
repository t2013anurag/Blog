﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validateUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool validateUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> validateUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/viewPost", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet viewPost();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/viewPost", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> viewPostAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createPost", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool createPost(string author, string title, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createPost", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> createPostAsync(string author, string title, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deletePost", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool deletePost(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deletePost", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> deletePostAsync(string title);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Website.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Website.ServiceReference1.WebService1Soap>, Website.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public bool validateUser(string username, string password) {
            return base.Channel.validateUser(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> validateUserAsync(string username, string password) {
            return base.Channel.validateUserAsync(username, password);
        }
        
        public System.Data.DataSet viewPost() {
            return base.Channel.viewPost();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> viewPostAsync() {
            return base.Channel.viewPostAsync();
        }
        
        public bool createPost(string author, string title, string description) {
            return base.Channel.createPost(author, title, description);
        }
        
        public System.Threading.Tasks.Task<bool> createPostAsync(string author, string title, string description) {
            return base.Channel.createPostAsync(author, title, description);
        }
        
        public bool deletePost(string title) {
            return base.Channel.deletePost(title);
        }
        
        public System.Threading.Tasks.Task<bool> deletePostAsync(string title) {
            return base.Channel.deletePostAsync(title);
        }
    }
}