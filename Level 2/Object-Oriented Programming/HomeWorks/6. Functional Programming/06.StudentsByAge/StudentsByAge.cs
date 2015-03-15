using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.ClassStudent;

namespace _06.StudentsByAge
{
    class StudentsByAge
    {
        static void Main(string[] args)
        {
            var result =
                from student in Student.students
                where student.Age > 18 & student.Age < 24
                select new
                {
                    student.FirstName,
                    student.LastName,
                    student.Age
                };

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

        }
    }
}
