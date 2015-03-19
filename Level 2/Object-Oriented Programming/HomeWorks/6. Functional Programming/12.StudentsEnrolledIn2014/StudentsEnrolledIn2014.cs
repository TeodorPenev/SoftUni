using System;
using _03.ClassStudent;

namespace _12.StudentsEnrolledIn2014
{
    class StudentsEnrolledIn2014
    {
        static void Main(string[] args)
        {
            var result = Student.students.FindAll(x => x.FacultyNumber.Enrolled());

            foreach (var student in result)
            {
                Console.WriteLine("Name: {0}, Marks: {1}", student.FirstName, String.Join(",", student.Marks));
            }
        }
    }
}
