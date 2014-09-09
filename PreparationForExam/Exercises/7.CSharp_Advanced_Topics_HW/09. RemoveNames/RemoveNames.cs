using System;
using System.Collections.Generic;
class RemoveNames
{
    static void Main()
    {
        List<string> names1 = new List<string>(Console.ReadLine().Split(' '));
        List<string> names2 = new List<string>(Console.ReadLine().Split(' '));
        List<string> result;
        int count=0;
        for (int i = 0; i < names2.Count; i++)
        {
            for (int j = 0; j < names1.Count; j++)
            {
                if (names2[i] == names1[j])
                {
                   names1.RemoveAt(j);
                   j--;
                }
            }
        }
        for (int t = 0; t < names1.Count; t++)
        {
            Console.Write("{0} ",names1[t]);
        }
        Console.WriteLine();
        PrintMyName(2,5);
    }
    
    static void PrintMyName(int a,int b)
{
    Console.WriteLine(a+b);
}

}

