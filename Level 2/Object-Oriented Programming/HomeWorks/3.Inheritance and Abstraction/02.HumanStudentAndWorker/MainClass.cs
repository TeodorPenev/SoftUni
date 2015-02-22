using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HumanStudentAndWorker
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Teodor", "Penev", "115084"),
                new Student("Mihaela", "Markova", "115070"),
                new Student("Deriq", "Halim", "115096"),
                new Student("Serap", "Nedjibova", "115124"),
                new Student("Desislava", "Markovska", "115124"),
                new Student("Cvetelina", "Asenova", "115024"),
                new Student("Teodor", "Georgiev", "112140"),
                new Student("Anatoli", "Petrov", "131440"),
                new Student("Liliq", "Petkova", "113110"),
            };

            Console.WriteLine("\n Sorted students by faculty number: \n");
            var sortByFaultyNumb = students.OrderBy(x => x.FaultyNumber);
            foreach (var student in sortByFaultyNumb)
            {
                Console.WriteLine("First and last name: {0} {1}",student.FirstName,student.LastName);
            }

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Velichko", "Adamov", 1200 , 5),
                new Worker("Luben", "Kirev", 1100 , 8),
                new Worker("Teodora", "Dimitrova", 900 , 8),
                new Worker("Elena", "Petkova", 800 , 10),
                new Worker("Snejana", "Genkova", 950.50 , 8),
                new Worker("Vencislav", "Tanev", 1150.99 , 7),
                new Worker("Georgi", "Gerganov", 950.99 , 4),
                new Worker("Bonka", "Chiprqnova", 750.50 , 8),
                new Worker("Velislava", "Kirilova", 650.50 , 6),
                new Worker("Narlen", "Chatmalieva", 850.69 , 8),
            };

            Console.WriteLine("\n Sorted workers by payment per hour: \n");
            var sortDescPayPerHour = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortDescPayPerHour)
            {
                Console.WriteLine("First and last name: {0} {1}",worker.FirstName,worker.LastName);
            }


            var sortByFirstName = (from stud in students
                                   select new
                                   {
                                       FirstName = stud.FirstName,
                                       LastName = stud.LastName,
                                   }
                                        ).Union(from worker in workers
                                                select new
                                                {
                                                    FirstName = worker.FirstName,
                                                    LastName = worker.LastName,
                                                }).OrderBy(x => x.FirstName).ThenBy(x=>x.LastName);

            Console.WriteLine("\n Sorted by first and last name: \n");
            foreach (var human in sortByFirstName)
            {
                Console.WriteLine("First and last name: {0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
