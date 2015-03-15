using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ClassStudent
{
    
   public class Student
   {
        static Student tedy = new Student("Teodor", "Penev", 28, 115011, "0895661848", "t.g.penev@gmail.com", new[] { 6, 6, 6, 6, 5 }, 26);
        static Student dany = new Student("Daniel", "Penev", 30, 223145, "0897561842", "d.penev@abv.bg", new[] { 4, 6, 5, 6, 5 }, 15);
        static Student toni = new Student("Toni", "Cvetkova", 22, 114557, "089696969", "shlqs_@gmail.com", new[] { 3, 3, 3, 3, 4 }, 21);
        static Student mihi = new Student("Mihaela", "Markowa", 23, 112217, "089878685", "m.markowa@gmail.com", new[] { 6, 6, 6, 6, 6 }, 26);

        public static List<Student> students = new List<Student>() { tedy, dany, toni, mihi };

        public Student(string firstName, string lastName, byte age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FacultyNumber = facultyNumber;
            Phone = phone;
            Email = email;
            Marks = marks;
            GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return String.Format(
                "First Name:{0}, Last Name:{1}, Age:{2}, Faculty Number:{3},\nPhone:{4}, Email:{5}, Marks:{6}, Group Number:{7}\n ",
                FirstName, LastName, Age, FacultyNumber, Phone, Email, String.Join(",", Marks), GroupNumber);
        }
    }
}
