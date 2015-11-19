using System;

namespace SharpHelpers.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsNotNullOrWhiteSpace(this string data)
        {
            return !string.IsNullOrWhiteSpace(data);
        }

        public static bool IsNullOrWhiteSpace(this string data)
        {
            return string.IsNullOrWhiteSpace(data);
        }

        public static string UseFormat(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static bool IsEqualIgnoreCase(this string data, string arg)
        {
            return data.Equals(arg, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsEqual(this string data, string arg)
        {
            return data.Equals(arg);
        }

        public static bool ContainsIgnoreCase(this string data, string compareWith)
        {
            return data.ToLower().Contains(compareWith.ToLower());
        }
    }
}
