using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ClassStudent
{
    class MainClass
    {
        static void Main(string[] args)
        {
           Student tedy = new Student("Teodor", "Penev", 28, 115011, "0895661848", "t.g.penev@gmail.com", new []{6, 6, 6, 6, 5}, 26);
           Student dany = new Student("Daniel", "Penev", 30, 223145, "0897561842", "d.penev@gmail.com", new[] { 4, 6, 5, 6, 5 }, 15);
           Student toni = new Student("Toni", "Cvetkova", 22, 114557, "089696969", "shlqs_@gmail.com", new[] { 3, 3, 3, 3, 4 }, 21);
           Student mihi = new Student("Mihaela", "Markowa", 23, 112217, "089878685", "m.markowa@gmail.com", new[] { 6, 6, 6, 6, 6 }, 26);

           List<Student> students = new List<Student>() {tedy, dany, toni, mihi};

           //Problem 4.	Students by Group
           //Print all students from group number 26. Use a LINQ query. Order the students by FirstName.
            var byGroupMatch =
                from student in students
                where student.GroupNumber == 26
                orderby student.FirstName
                select student;

            foreach (var student in byGroupMatch)
            {
                Console.WriteLine(student);
            }

            //Problem 5. Students by First and Last Name
            //Print all students whose first name is before their last name alphabetically. Use a LINQ query.
            var byNames =
                from student in students
                where student.FirstName.CompareTo(student.LastName)==-1
                select student;

            foreach (var student in byNames)
            {
                Console.WriteLine(student);
            }
        }
    }
}
