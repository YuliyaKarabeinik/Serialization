using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempForDelegate
{
    public static class ExtensionList
    {
        public static string ExtensionToString<T>(this List<T> list)
        {
            StringBuilder result = new StringBuilder();
            foreach (T item in list)
                result.AppendLine(item.ToString());
            return result.ToString();
        }
    }
}
