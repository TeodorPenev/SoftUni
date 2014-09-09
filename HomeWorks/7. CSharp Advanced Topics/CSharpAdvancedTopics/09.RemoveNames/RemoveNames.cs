using System;
using System.Collections.Generic;
class RemoveNames
{
    static void Main()
    {
        string[] firstStr = Console.ReadLine().Split(' ');
        string[] secondStr = Console.ReadLine().Split(' ');
        List<string> first = new List<string>();
        List<string> second = new List<string>();

        for (int i = 0; i < firstStr.Length; i++)
        {
            first.Add(firstStr[i]);
        }

        for (int i = 0; i < secondStr.Length; i++)
        {
            second.Add(secondStr[i]);
        }

        for (int i = 0; i < first.Count; i++)
        {
            for (int j = 0; j < second.Count; j++)
            {
                if (first[i] == second[j])
                {
                    first.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }
        for (int i = 0; i < first.Count; i++)
        {
            Console.Write("{0} ", first[i]);
        }
        Console.WriteLine();

    }
}

