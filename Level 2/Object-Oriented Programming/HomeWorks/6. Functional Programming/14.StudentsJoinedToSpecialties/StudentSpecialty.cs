using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.StudentsJoinedToSpecialties
{
    class StudentSpecialty
    {
        static StudentSpecialty web1 = new StudentSpecialty("Web Developer", 1122127);
        static StudentSpecialty web2 = new StudentSpecialty("Web Developer", 1145114);
        static StudentSpecialty qa1 = new StudentSpecialty("QA Engineer", 1150146);
        static StudentSpecialty qa2 = new StudentSpecialty("QA Engineer", 2231145);

        public static List<StudentSpecialty> specialty = new List<StudentSpecialty>() {web1, web2, qa1, qa2};

        public StudentSpecialty(string specialityName, int facultyNumber)
        {
            this.SpecialityName = specialityName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialityName { get; set; }
        public int FacultyNumber { get; set; }

        public override string ToString()
        {
            string result = String.Format("Speciality Name: {0}, Faculty Number: {1}", this.SpecialityName,
                this.FacultyNumber);
            return result;
        }
    }
}
