namespace proxies
{
    public interface IInterceptor
    {
        void Intercept(IInvocation invocation);
    }
}