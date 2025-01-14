﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _0427_Service_CLient_.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICal", CallbackContract=typeof(_0427_Service_CLient_.ServiceReference1.ICalCallback))]
    public interface ICal {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICal/Add")]
        void Add(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ICal/Add")]
        System.IAsyncResult BeginAdd(int num1, int num2, System.AsyncCallback callback, object asyncState);
        
        void EndAdd(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICal/Sub")]
        void Sub(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ICal/Sub")]
        System.IAsyncResult BeginSub(int num1, int num2, System.AsyncCallback callback, object asyncState);
        
        void EndSub(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICal/Mul")]
        void Mul(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ICal/Mul")]
        System.IAsyncResult BeginMul(int num1, int num2, System.AsyncCallback callback, object asyncState);
        
        void EndMul(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICal/Div")]
        void Div(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ICal/Div")]
        System.IAsyncResult BeginDiv(int num1, int num2, System.AsyncCallback callback, object asyncState);
        
        void EndDiv(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICal/Result")]
        void Result([System.ServiceModel.MessageParameterAttribute(Name="result")] float result1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ICal/Result")]
        System.IAsyncResult BeginResult(float result, System.AsyncCallback callback, object asyncState);
        
        void EndResult(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalChannel : _0427_Service_CLient_.ServiceReference1.ICal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalClient : System.ServiceModel.DuplexClientBase<_0427_Service_CLient_.ServiceReference1.ICal>, _0427_Service_CLient_.ServiceReference1.ICal {
        
        private BeginOperationDelegate onBeginAddDelegate;
        
        private EndOperationDelegate onEndAddDelegate;
        
        private System.Threading.SendOrPostCallback onAddCompletedDelegate;
        
        private BeginOperationDelegate onBeginSubDelegate;
        
        private EndOperationDelegate onEndSubDelegate;
        
        private System.Threading.SendOrPostCallback onSubCompletedDelegate;
        
        private BeginOperationDelegate onBeginMulDelegate;
        
        private EndOperationDelegate onEndMulDelegate;
        
        private System.Threading.SendOrPostCallback onMulCompletedDelegate;
        
        private BeginOperationDelegate onBeginDivDelegate;
        
        private EndOperationDelegate onEndDivDelegate;
        
        private System.Threading.SendOrPostCallback onDivCompletedDelegate;
        
        public CalClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AddCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SubCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> MulCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DivCompleted;
        
        public void Add(int num1, int num2) {
            base.Channel.Add(num1, num2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginAdd(int num1, int num2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAdd(num1, num2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndAdd(System.IAsyncResult result) {
            base.Channel.EndAdd(result);
        }
        
        private System.IAsyncResult OnBeginAdd(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int num1 = ((int)(inValues[0]));
            int num2 = ((int)(inValues[1]));
            return this.BeginAdd(num1, num2, callback, asyncState);
        }
        
        private object[] OnEndAdd(System.IAsyncResult result) {
            this.EndAdd(result);
            return null;
        }
        
        private void OnAddCompleted(object state) {
            if ((this.AddCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddAsync(int num1, int num2) {
            this.AddAsync(num1, num2, null);
        }
        
        public void AddAsync(int num1, int num2, object userState) {
            if ((this.onBeginAddDelegate == null)) {
                this.onBeginAddDelegate = new BeginOperationDelegate(this.OnBeginAdd);
            }
            if ((this.onEndAddDelegate == null)) {
                this.onEndAddDelegate = new EndOperationDelegate(this.OnEndAdd);
            }
            if ((this.onAddCompletedDelegate == null)) {
                this.onAddCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddCompleted);
            }
            base.InvokeAsync(this.onBeginAddDelegate, new object[] {
                        num1,
                        num2}, this.onEndAddDelegate, this.onAddCompletedDelegate, userState);
        }
        
        public void Sub(int num1, int num2) {
            base.Channel.Sub(num1, num2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSub(int num1, int num2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSub(num1, num2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndSub(System.IAsyncResult result) {
            base.Channel.EndSub(result);
        }
        
        private System.IAsyncResult OnBeginSub(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int num1 = ((int)(inValues[0]));
            int num2 = ((int)(inValues[1]));
            return this.BeginSub(num1, num2, callback, asyncState);
        }
        
        private object[] OnEndSub(System.IAsyncResult result) {
            this.EndSub(result);
            return null;
        }
        
        private void OnSubCompleted(object state) {
            if ((this.SubCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SubCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SubAsync(int num1, int num2) {
            this.SubAsync(num1, num2, null);
        }
        
        public void SubAsync(int num1, int num2, object userState) {
            if ((this.onBeginSubDelegate == null)) {
                this.onBeginSubDelegate = new BeginOperationDelegate(this.OnBeginSub);
            }
            if ((this.onEndSubDelegate == null)) {
                this.onEndSubDelegate = new EndOperationDelegate(this.OnEndSub);
            }
            if ((this.onSubCompletedDelegate == null)) {
                this.onSubCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSubCompleted);
            }
            base.InvokeAsync(this.onBeginSubDelegate, new object[] {
                        num1,
                        num2}, this.onEndSubDelegate, this.onSubCompletedDelegate, userState);
        }
        
        public void Mul(int num1, int num2) {
            base.Channel.Mul(num1, num2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginMul(int num1, int num2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginMul(num1, num2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndMul(System.IAsyncResult result) {
            base.Channel.EndMul(result);
        }
        
        private System.IAsyncResult OnBeginMul(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int num1 = ((int)(inValues[0]));
            int num2 = ((int)(inValues[1]));
            return this.BeginMul(num1, num2, callback, asyncState);
        }
        
        private object[] OnEndMul(System.IAsyncResult result) {
            this.EndMul(result);
            return null;
        }
        
        private void OnMulCompleted(object state) {
            if ((this.MulCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.MulCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void MulAsync(int num1, int num2) {
            this.MulAsync(num1, num2, null);
        }
        
        public void MulAsync(int num1, int num2, object userState) {
            if ((this.onBeginMulDelegate == null)) {
                this.onBeginMulDelegate = new BeginOperationDelegate(this.OnBeginMul);
            }
            if ((this.onEndMulDelegate == null)) {
                this.onEndMulDelegate = new EndOperationDelegate(this.OnEndMul);
            }
            if ((this.onMulCompletedDelegate == null)) {
                this.onMulCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnMulCompleted);
            }
            base.InvokeAsync(this.onBeginMulDelegate, new object[] {
                        num1,
                        num2}, this.onEndMulDelegate, this.onMulCompletedDelegate, userState);
        }
        
        public void Div(int num1, int num2) {
            base.Channel.Div(num1, num2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDiv(int num1, int num2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDiv(num1, num2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndDiv(System.IAsyncResult result) {
            base.Channel.EndDiv(result);
        }
        
        private System.IAsyncResult OnBeginDiv(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int num1 = ((int)(inValues[0]));
            int num2 = ((int)(inValues[1]));
            return this.BeginDiv(num1, num2, callback, asyncState);
        }
        
        private object[] OnEndDiv(System.IAsyncResult result) {
            this.EndDiv(result);
            return null;
        }
        
        private void OnDivCompleted(object state) {
            if ((this.DivCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DivCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DivAsync(int num1, int num2) {
            this.DivAsync(num1, num2, null);
        }
        
        public void DivAsync(int num1, int num2, object userState) {
            if ((this.onBeginDivDelegate == null)) {
                this.onBeginDivDelegate = new BeginOperationDelegate(this.OnBeginDiv);
            }
            if ((this.onEndDivDelegate == null)) {
                this.onEndDivDelegate = new EndOperationDelegate(this.OnEndDiv);
            }
            if ((this.onDivCompletedDelegate == null)) {
                this.onDivCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDivCompleted);
            }
            base.InvokeAsync(this.onBeginDivDelegate, new object[] {
                        num1,
                        num2}, this.onEndDivDelegate, this.onDivCompletedDelegate, userState);
        }
    }
}
