using System.Collections.Generic;
using System.Text;

namespace _01.StringBuilderExtensions
{
    public static class Extensions
    {
        public static string Substring(this StringBuilder stringBuilder, int startIndex, int lenght)
        {
            string result = stringBuilder.ToString();
            result = result.Substring(startIndex, lenght);
            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder stringBuilder, string text)
        {
            return stringBuilder.Replace(text, null);
        }

        public static string AppendAll<T>(this IEnumerable<T> items)
        {
            string result = "";
            foreach (var item in items)
            {
                result +=item.ToString()+" ";
            }
            return result;
        }
    }
}
