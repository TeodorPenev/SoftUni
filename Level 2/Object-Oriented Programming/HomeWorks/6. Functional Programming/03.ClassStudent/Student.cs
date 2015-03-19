using System;
using System.Collections.Generic;

namespace _03.ClassStudent
{
    
   public class Student
   {
        static Student tedy = new Student("Teodor", "Penev", 28, 1150146, "0885661848", "t.g.penev@gmail.com", new[] { 6, 6, 6, 6, 5 }, 26,"Loosers");
        static Student dany = new Student("Daniel", "Penev", 30, 2231145, "0877561842", "d.penev@abv.bg", new[] { 4, 5, 5, 5, 5 }, 15,"Fly");
        static Student toni = new Student("Toni", "Cvetkova", 22, 1145114, "089696969", "shlqs_@gmail.com", new[] { 3, 2, 3, 2, 4 }, 21,"Fly");
        static Student mihi = new Student("Mihaela", "Markowa", 23, 1122127, "089878685", "m.markowa@gmail.com", new[] { 6, 6, 6, 6, 6 }, 26,"Loosers");

        public static List<Student> students = new List<Student>() { tedy, dany, toni, mihi };

        public Student(string firstName, string lastName, byte age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber,string groupName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FacultyNumber = facultyNumber;
            Phone = phone;
            Email = email;
            Marks = marks;
            GroupNumber = groupNumber;
            GroupName = groupName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public string GroupName { get; set; } 

        public override string ToString()
        {
            return String.Format(
                "First Name:{0}, Last Name:{1}, Age:{2}, Faculty Number:{3},\nPhone:{4}, Email:{5}, Marks:{6}, Group Number:{7}\n ",
                FirstName, LastName, Age, FacultyNumber, Phone, Email, String.Join(",", Marks), GroupNumber);
        }
    }
}
