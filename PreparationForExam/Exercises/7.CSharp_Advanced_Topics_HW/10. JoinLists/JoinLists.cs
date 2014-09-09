using System;
using System.Collections.Generic;
using System.Linq;
class JoinLists
{
    static void Main()
    {
        List<string> num1S = new List<string>(Console.ReadLine().Split(' '));
        List<string> num2S = new List<string>(Console.ReadLine().Split(' '));
        List<string> result = new List<string>();
        List<int> num1I = new List<int>();
        List<int> num2I = new List<int>();

        result = num1S.Union(num2S).ToList();
        result.Sort();
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write("{0} ",result[i]);
        }
    }
}

