using System;
using System.Collections.Generic;
using System.Linq;
class CountOfNames
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');
        HashSet<string> uniqueH = new HashSet<string>();
        int count = 0;
        Array.Sort(names);

        for (int i = 0; i < names.Length; i++)
        {
            uniqueH.Add(names[i]);
        }
        string[] unique = uniqueH.ToArray();

        for (int i = 0; i < unique.Length; i++)
        {
            for (int j = 0; j < names.Length; j++)
            {
                if (unique[i] == names[j])
                {
                    count++;
                }
            }
            Console.WriteLine(unique[i] + "->" + count);
            count = 0;
        }
    }
}

