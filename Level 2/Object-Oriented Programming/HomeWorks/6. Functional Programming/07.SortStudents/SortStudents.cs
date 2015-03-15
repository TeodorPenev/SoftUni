using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.ClassStudent;

namespace _07.SortStudents
{
    class SortStudents
    {
        static void Main(string[] args)
        {
            var lambdaResult = Student.students
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);

            foreach (var student in lambdaResult)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\n");

            var linqResult =
                from student in Student.students
                orderby student.FirstName descending,student.LastName descending 
                select student;

            foreach (var student in linqResult)
            {
                Console.WriteLine(student);
            }
        }
    }
}
