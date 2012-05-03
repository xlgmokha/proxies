using System.Diagnostics;

namespace proxies
{
    public static class assertion_extensions
    {
        public static void should_be_equal_to<T>(this T left, T right)
        {
            Debug.Assert(left.Equals(right), "{0} is not equal to {1}".format_with(left, right));
        }
    }
}