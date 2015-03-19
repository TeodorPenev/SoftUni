using System;
using System.Linq;
using _03.ClassStudent;

namespace _10.ExcellentStudents
{
    class ExcellentStudents
    {
        static void Main(string[] args)
        {
            var result =
                from student in Student.students
                where student.Marks.Contains(6)
                select new {FullName=student.FirstName+" "+student.LastName,Marks=student.Marks};

            foreach (var student in result)
            {
                Console.WriteLine(String.Format("Full Name: {0} Marks: {1}", student.FullName,String.Join(", ", student.Marks)));
            }
        }
    }
}
