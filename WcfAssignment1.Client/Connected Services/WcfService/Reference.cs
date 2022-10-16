﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfAssignment1.Client.WcfService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsPrimeNumber", ReplyAction="http://tempuri.org/IService/IsPrimeNumberResponse")]
        bool IsPrimeNumber(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsPrimeNumber", ReplyAction="http://tempuri.org/IService/IsPrimeNumberResponse")]
        System.Threading.Tasks.Task<bool> IsPrimeNumberAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SumDigits", ReplyAction="http://tempuri.org/IService/SumDigitsResponse")]
        int SumDigits(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SumDigits", ReplyAction="http://tempuri.org/IService/SumDigitsResponse")]
        System.Threading.Tasks.Task<int> SumDigitsAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReverseString", ReplyAction="http://tempuri.org/IService/ReverseStringResponse")]
        string ReverseString(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReverseString", ReplyAction="http://tempuri.org/IService/ReverseStringResponse")]
        System.Threading.Tasks.Task<string> ReverseStringAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MakeHtmlTag", ReplyAction="http://tempuri.org/IService/MakeHtmlTagResponse")]
        string MakeHtmlTag(string tag, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MakeHtmlTag", ReplyAction="http://tempuri.org/IService/MakeHtmlTagResponse")]
        System.Threading.Tasks.Task<string> MakeHtmlTagAsync(string tag, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Sort", ReplyAction="http://tempuri.org/IService/SortResponse")]
        int[] Sort(int[] value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Sort", ReplyAction="http://tempuri.org/IService/SortResponse")]
        System.Threading.Tasks.Task<int[]> SortAsync(int[] value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WcfAssignment1.Client.WcfService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WcfAssignment1.Client.WcfService.IService>, WcfAssignment1.Client.WcfService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IsPrimeNumber(int value) {
            return base.Channel.IsPrimeNumber(value);
        }
        
        public System.Threading.Tasks.Task<bool> IsPrimeNumberAsync(int value) {
            return base.Channel.IsPrimeNumberAsync(value);
        }
        
        public int SumDigits(int value) {
            return base.Channel.SumDigits(value);
        }
        
        public System.Threading.Tasks.Task<int> SumDigitsAsync(int value) {
            return base.Channel.SumDigitsAsync(value);
        }
        
        public string ReverseString(string value) {
            return base.Channel.ReverseString(value);
        }
        
        public System.Threading.Tasks.Task<string> ReverseStringAsync(string value) {
            return base.Channel.ReverseStringAsync(value);
        }
        
        public string MakeHtmlTag(string tag, string value) {
            return base.Channel.MakeHtmlTag(tag, value);
        }
        
        public System.Threading.Tasks.Task<string> MakeHtmlTagAsync(string tag, string value) {
            return base.Channel.MakeHtmlTagAsync(tag, value);
        }
        
        public int[] Sort(int[] value) {
            return base.Channel.Sort(value);
        }
        
        public System.Threading.Tasks.Task<int[]> SortAsync(int[] value) {
            return base.Channel.SortAsync(value);
        }
    }
}