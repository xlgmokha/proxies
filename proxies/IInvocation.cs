using System.Reflection;

namespace proxies
{
    public interface IInvocation
    {
        void Proceed();
        object[] Arguments { get; }
        MethodInfo Method { get; }
        object ReturnValue { get; set; }
    }
}