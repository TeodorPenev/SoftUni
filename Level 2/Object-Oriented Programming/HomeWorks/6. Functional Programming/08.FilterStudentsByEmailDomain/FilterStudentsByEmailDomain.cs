using System;
using System.Linq;
using _03.ClassStudent;

namespace _08.FilterStudentsByEmailDomain
{
    class FilterStudentsByEmailDomain
    {
        static void Main(string[] args)
        {
            var result =
                from student in Student.students
                where student.Email.Contains("abv.bg")
                select student;

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}
