using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StringBuilderExtensions
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder();
            test.Append("TeodorPenev");
            Console.WriteLine(test.Substring(4, 4));

            Console.WriteLine(test.RemoveText("Penev"));

            List<string> students = new List<string>() {"Teodor", "Daniel", "Mihail"};
            Console.WriteLine(students.AppendAll());
            
        }
    }
}
