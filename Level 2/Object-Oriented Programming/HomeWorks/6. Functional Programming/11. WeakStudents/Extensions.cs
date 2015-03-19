using System;
using System.Collections.Generic;
using _03.ClassStudent;

namespace _11.WeakStudents
{
      public static class Extensions
    {
           public static List<Student> FullExtractExactly(this List<Student> students,int mark,int count)
           {
               List<Student> result = new List<Student>();
               int counter = 0;
               foreach (var stud in students)
               {
                   foreach (var rate in stud.Marks)
                   {
                       if (rate==mark)
                       {
                           counter++;   
                       }
                   }
                   if (counter == count)
                   {
                       result.Add(stud);
                       counter = 0;
                   }
                   else
                   {
                       counter = 0;
                   }
               }
               return result;
           }

          public static Boolean ContainCount(this IList<int> type, int mark, int count)
          {
              int counter = 0;
              foreach (var rate in type)
              {
                  if (rate == mark)
                  {
                      counter++;
                  }
              }
              if (counter == count)
              {
                  return true;
              }
              return false;
          }
    }
}
