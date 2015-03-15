using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.ClassStudent;

namespace _04.StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main(string[] args)
        {
            var byGroupMatch =
               from student in Student.students
               where student.GroupNumber == 26
               orderby student.FirstName
               select student;

            foreach (var student in byGroupMatch)
            {
                Console.WriteLine(student);
            }

        }
    }
}
