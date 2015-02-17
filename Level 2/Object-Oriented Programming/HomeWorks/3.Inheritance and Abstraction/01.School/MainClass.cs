using System;
using System.Collections.Generic;

namespace _01.School
{
    class MainClass
    {
        public static void Main()
        {
            Class test = new Class("cherry",new List<string> {"Papazova","Nikolov"},"none");
            Console.WriteLine(test);
        }
    }
}
