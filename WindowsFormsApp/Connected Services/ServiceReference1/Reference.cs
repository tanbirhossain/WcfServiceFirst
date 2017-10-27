﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceCalculator")]
    public interface IServiceCalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/AddNumbers", ReplyAction="http://tempuri.org/IServiceCalculator/AddNumbersResponse")]
        double AddNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/AddNumbers", ReplyAction="http://tempuri.org/IServiceCalculator/AddNumbersResponse")]
        System.Threading.Tasks.Task<double> AddNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/SubstractNumbers", ReplyAction="http://tempuri.org/IServiceCalculator/SubstractNumbersResponse")]
        double SubstractNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/SubstractNumbers", ReplyAction="http://tempuri.org/IServiceCalculator/SubstractNumbersResponse")]
        System.Threading.Tasks.Task<double> SubstractNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/MultiplyNumbers", ReplyAction="http://tempuri.org/IServiceCalculator/MultiplyNumbersResponse")]
        double MultiplyNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/MultiplyNumbers", ReplyAction="http://tempuri.org/IServiceCalculator/MultiplyNumbersResponse")]
        System.Threading.Tasks.Task<double> MultiplyNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/DivisionNumber", ReplyAction="http://tempuri.org/IServiceCalculator/DivisionNumberResponse")]
        double DivisionNumber(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/DivisionNumber", ReplyAction="http://tempuri.org/IServiceCalculator/DivisionNumberResponse")]
        System.Threading.Tasks.Task<double> DivisionNumberAsync(double number1, double number2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCalculatorChannel : WindowsFormsApp.ServiceReference1.IServiceCalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCalculatorClient : System.ServiceModel.ClientBase<WindowsFormsApp.ServiceReference1.IServiceCalculator>, WindowsFormsApp.ServiceReference1.IServiceCalculator {
        
        public ServiceCalculatorClient() {
        }
        
        public ServiceCalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double AddNumbers(double number1, double number2) {
            return base.Channel.AddNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> AddNumbersAsync(double number1, double number2) {
            return base.Channel.AddNumbersAsync(number1, number2);
        }
        
        public double SubstractNumbers(double number1, double number2) {
            return base.Channel.SubstractNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> SubstractNumbersAsync(double number1, double number2) {
            return base.Channel.SubstractNumbersAsync(number1, number2);
        }
        
        public double MultiplyNumbers(double number1, double number2) {
            return base.Channel.MultiplyNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyNumbersAsync(double number1, double number2) {
            return base.Channel.MultiplyNumbersAsync(number1, number2);
        }
        
        public double DivisionNumber(double number1, double number2) {
            return base.Channel.DivisionNumber(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DivisionNumberAsync(double number1, double number2) {
            return base.Channel.DivisionNumberAsync(number1, number2);
        }
    }
}
