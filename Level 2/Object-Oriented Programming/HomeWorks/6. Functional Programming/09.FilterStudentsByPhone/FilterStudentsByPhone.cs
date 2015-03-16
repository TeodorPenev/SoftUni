using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.ClassStudent;

namespace _09.FilterStudentsByPhone
{
    class FilterStudentsByPhone
    {
        static void Main(string[] args)
        {
            var result =
                from student in Student.students
                where student.Phone.StartsWith("087") || student.Phone.StartsWith("088")
                select student;

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}
