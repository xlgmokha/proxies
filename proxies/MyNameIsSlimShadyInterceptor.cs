namespace proxies
{
    public class MyNameIsSlimShadyInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            invocation.ReturnValue = "slim shady";
        }
    }
}