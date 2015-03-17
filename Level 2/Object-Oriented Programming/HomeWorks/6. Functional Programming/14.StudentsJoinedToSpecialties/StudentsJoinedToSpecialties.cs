using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.ClassStudent;

namespace _14.StudentsJoinedToSpecialties
{
    class StudentsJoinedToSpecialties
    {
        static void Main(string[] args)
        {
            var joined =
                from student in Student.students
                join subject in StudentSpecialty.specialty
                    on student.FacultyNumber equals subject.FacultyNumber
                orderby (student.FirstName)
                select
                    new
                    {
                        Name = student.FirstName + " " + student.LastName,
                        FacNum = student.FacultyNumber,
                        Specialty = subject.SpecialityName
                    }.ToString();

            foreach (var sortedStudent in joined)
            {
                Console.WriteLine(sortedStudent);
            }
        }
    }
}
