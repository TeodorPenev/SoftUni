using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentAndWorker
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student TeodorP = new Student("Teodor","Penev","115084");
            Student Mihaela = new Student("Mihaela", "Markova", "115070");
            Student Deriq = new Student("Deriq", "Halim", "115096");
            Student Serap = new Student("Serap", "Nedjibova", "115124");
            Student Desislava = new Student("Desislava", "Markovska", "115124");
            Student Cvetelina = new Student("Cvetelina", "Asenova", "115024");
            Student TeodorG = new Student("Teodor", "Georgiev", "112140");
            Student Anatoli = new Student("Anatoli", "Petrov", "131440");
            Student Liliq = new Student("Liliq", "Petkova", "113110");
            Student Aleksandra = new Student("Aleksandra", "Karamfilova", "153110");

            students.Add(TeodorP);
            students.Add(Mihaela);
            students.Add(Deriq);
            students.Add(Serap);
            students.Add(Desislava);
            students.Add(Cvetelina);
            students.Add(TeodorG);
            students.Add(Anatoli);
            students.Add(Liliq);
            students.Add(Aleksandra);


        }
    }
}
