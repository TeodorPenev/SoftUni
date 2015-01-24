using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class PersonsTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter email: ");
            string email = Console.ReadLine();
            Person testPerson = new Person(name,age,email);
            Console.WriteLine(testPerson);
        }
    }
}
