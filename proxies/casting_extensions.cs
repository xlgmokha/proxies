namespace proxies
{
    public static class casting_extensions
    {
        public static bool is_a<T>(this object item) where T : class
        {
            return item as T != null;
        }

        public static T downcast_to<T>(this object item)
        {
            return (T) item;
        }
    }
}