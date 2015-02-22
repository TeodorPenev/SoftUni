using System;
using System.Linq;

namespace Animals
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Dog[] dogs =
            {
                new Dog("Teodor", 27, "male"),
                new Dog("Desi", 23, "female")
            };

            Frog[] frogs =
            {
                new Frog("Zara", 16, "femele"),
                new Frog("Petq", 12, "femele")
            };

            Kitten[] kittens =
            {
                new Kitten("Silviq", 20),
                new Kitten("Nikoleta", 19)
            };

            Tomcat[] tomcats={
                new Tomcat("Milen", 30), 
                new Tomcat("Tihomir", 28), 
            };

            var averageDogs = dogs.Average(r => r.age);
            var averageFrogs = frogs.Average(r => r.age);
            var averageKittens = kittens.Average(r => r.age);
            var averageTomcats = tomcats.Average(r => r.age);
        }
    }
}
