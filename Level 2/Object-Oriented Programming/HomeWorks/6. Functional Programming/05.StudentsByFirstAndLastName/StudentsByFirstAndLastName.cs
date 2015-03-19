using System;
using System.Linq;
using _03.ClassStudent;

namespace _05.StudentsByFirstAndLastName
{

    class StudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            var byNames =
                from student in Student.students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (var student in byNames)
            {
                Console.WriteLine(student);
            }            
        }
    }
}
