﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubstringFinder.ConsoleClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISubstringFinder")]
    public interface ISubstringFinder {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubstringFinder/GetSubstringCount", ReplyAction="http://tempuri.org/ISubstringFinder/GetSubstringCountResponse")]
        int GetSubstringCount(string text, string substr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubstringFinder/GetSubstringCount", ReplyAction="http://tempuri.org/ISubstringFinder/GetSubstringCountResponse")]
        System.Threading.Tasks.Task<int> GetSubstringCountAsync(string text, string substr);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubstringFinderChannel : SubstringFinder.ConsoleClient.ServiceReference1.ISubstringFinder, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubstringFinderClient : System.ServiceModel.ClientBase<SubstringFinder.ConsoleClient.ServiceReference1.ISubstringFinder>, SubstringFinder.ConsoleClient.ServiceReference1.ISubstringFinder {
        
        public SubstringFinderClient() {
        }
        
        public SubstringFinderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubstringFinderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubstringFinderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubstringFinderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetSubstringCount(string text, string substr) {
            return base.Channel.GetSubstringCount(text, substr);
        }
        
        public System.Threading.Tasks.Task<int> GetSubstringCountAsync(string text, string substr) {
            return base.Channel.GetSubstringCountAsync(text, substr);
        }
    }
}