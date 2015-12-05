using System.Collections.Generic;
using System.Linq;

namespace SharpHelpers.ExtensionMethods
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || source.Count() == 0;
        }
    }
}
