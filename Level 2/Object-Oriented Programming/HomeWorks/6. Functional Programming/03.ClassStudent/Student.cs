using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ClassStudent
{
    class Student
    {
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
