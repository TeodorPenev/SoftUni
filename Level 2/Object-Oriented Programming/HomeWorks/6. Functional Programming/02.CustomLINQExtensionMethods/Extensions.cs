using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CustomLINQExtensionMethods
{
   public static class Extensions
    {
       public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
       {
           IEnumerable<T> result =
               from item in collection
               where !predicate(item)
               select item;
           return result;
       }

       public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
       {
           IEnumerable<T> result = collection;

           for (int i = 0; i < count - 1; i++)
           {
               result = result.Concat(collection);
           }
           return result;
       }

       public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
       {
           var results =
                from item in collection
                from suffix in suffixes
                where item.EndsWith(suffix)
                select item;

           return results;
       } 
    }
}
