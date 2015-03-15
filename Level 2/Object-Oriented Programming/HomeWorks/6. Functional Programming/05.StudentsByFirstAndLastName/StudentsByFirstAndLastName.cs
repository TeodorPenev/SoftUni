using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
