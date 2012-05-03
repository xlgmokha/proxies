using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace proxies
{
    public class RemotingProxyFactory<T> : RealProxy
    {
        private readonly T target;
        private readonly IEnumerable<IInterceptor> interceptors;

        public RemotingProxyFactory(T target, IEnumerable<IInterceptor> interceptors) : base(typeof (T))
        {
            this.target = target;
            this.interceptors = interceptors;
        }

        public override IMessage Invoke(IMessage message)
        {
            if (message.is_a<IMethodCallMessage>())
            {
                var call = message.downcast_to<IMethodCallMessage>();
                var invocation = new MethodCallInvocation<T>(interceptors, call, target);
                invocation.Proceed();
                return ReturnValue(invocation.ReturnValue, invocation.Arguments, call);
            }
            return null;
        }

        private IMessage ReturnValue(object return_value, object[] out_parameters, IMethodCallMessage call)
        {
            return new ReturnMessage(return_value,
                                     out_parameters,
                                     out_parameters == null ? 0 : out_parameters.Length,
                                     call.LogicalCallContext, call);
        }

        public T CreateProxy()
        {
            return GetTransparentProxy().downcast_to<T>();
        }
    }
}