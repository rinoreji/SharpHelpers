using System;

namespace SharpHelpers.ExtensionMethods
{
    public static class OSExtensions
    {
        public static string ExpandPath(this string path)
        {
            return Environment.ExpandEnvironmentVariables(path);
        }
    }
}
