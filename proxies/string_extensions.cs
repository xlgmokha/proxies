using System.Globalization;

namespace proxies
{
    public static class string_extensions
    {
        public static string format_with(this string formatted_message, params object[] arguments)
        {
            return string.Format(CultureInfo.InvariantCulture, formatted_message, arguments);
        }
    }
}