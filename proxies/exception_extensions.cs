using System;
using System.Reflection;

namespace proxies
{
    public static class exception_extensions
    {
        private static readonly MethodInfo preserveStackTrace =
            typeof (Exception).GetMethod("InternalPreserveStackTrace",
                                         BindingFlags.NonPublic | BindingFlags.Instance);

        public static Exception PreserveStackTrace(this Exception exception)
        {
            preserveStackTrace.Invoke(exception, new object[0]);
            return exception;
        }
    }
}