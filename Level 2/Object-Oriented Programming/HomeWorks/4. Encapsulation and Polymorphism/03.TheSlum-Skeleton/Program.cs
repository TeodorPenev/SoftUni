using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using TheSlum.GameEngine;

namespace TheSlum
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Character> characterList=new List<Character>();
            Warrior Tedy = new Warrior("911",2,2,Team.Red);
            Warrior Dani = new Warrior("112",4,4,Team.Blue);
            characterList.Add(Dani);
            Console.WriteLine(Tedy);
             

            Engine engine = new Engine();
            engine.Run();
        }
    }
}
