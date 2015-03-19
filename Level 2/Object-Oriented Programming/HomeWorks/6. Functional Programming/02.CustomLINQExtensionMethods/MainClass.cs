using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CustomLINQExtensionMethods
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() {"Teodor", "Daniel", "Mihail"};
            var notMe = students.Where(x => x == "Teodor");
            
            foreach (var student in notMe)
            {
                Console.WriteLine(student);    
            }

            Console.WriteLine("\n");

            List<string> teachers = new List<string>() { "Vurbanov", "Kraeva", "Lalev" };
            var cloningsTeacher = teachers.Repeat(5);

            foreach (var teacher in cloningsTeacher)
            {
                Console.WriteLine(teacher);
            }

            List<string> games = new List<string>() { "StarCraft", "WarCraft", "Diablo" };
            List<string> suffixes = new List<string>() {"Craft", "War"};

            var filterGames = games.WhereEndsWith(suffixes);

            foreach (var game in filterGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
