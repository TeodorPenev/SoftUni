using System;
using System.Collections.Generic;
using System.Linq;
class JoinLists
{
    static void Main()
    {
        string[] firstStr = Console.ReadLine().Split(' ');
        string[] secondStr = Console.ReadLine().Split(' ');
        List<int> first = new List<int>();
        List<int> second = new List<int>();

        for (int i = 0; i < firstStr.Length; i++)
        {
            first.Add(int.Parse(firstStr[i]));
        }

        for (int i = 0; i < secondStr.Length; i++)
        {
            second.Add(int.Parse(secondStr[i]));
        }
        List<int> together = new List<int>(first.Union(second));
        together.Sort();

        for (int i = 0; i <together.Count; i++)
        {
            Console.Write("{0} ",together[i]);
        }
        Console.WriteLine();
    }
}


