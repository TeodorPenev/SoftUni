using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Dog("Teodor", 27, "male"),
                new Dog("Desi", 23, "female"),
                new Frog("Zara",16,"femele"), 
                new Frog("Petq",12,"femele"), 
                new Kitten("Silviq", 20),
                new Kitten("Nikoleta", 19),
                new Tomcat("Milen", 30), 
                new Tomcat("Tihomir", 28), 
            };
            var averageAge = (from creature in animals select new {Age = creature.Age}).OrderBy(x => x.Age);

            foreach (var crea in averageAge)
            {
                Console.WriteLine(crea);
            }
        }


        //var sortByFirstName = (from stud in students
        //                       select new
        //                       {
        //                           FirstName = stud.FirstName,
        //                           LastName = stud.LastName,
        //                       }
        //                            ).Union(from worker in workers
        //                                    select new
        //                                    {
        //                                        FirstName = worker.FirstName,
        //                                        LastName = worker.LastName,
        //                                    }).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
        
        
    }
}
