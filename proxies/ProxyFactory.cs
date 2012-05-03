namespace proxies
{
    public static class ProxyFactory
    {
        public static T Create<T>(T target, params IInterceptor[] interceptors)
        {
            return new RemotingProxyFactory<T>(target, interceptors).CreateProxy();
        }
    }
}