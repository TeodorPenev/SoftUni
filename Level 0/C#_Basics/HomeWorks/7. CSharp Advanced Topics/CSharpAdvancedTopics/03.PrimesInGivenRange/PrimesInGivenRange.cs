using System;
using System.Collections.Generic;
class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        PrintList(FindPrimesInRange(startNum, endNum));
    }
    static void PrintList(List<int> list)
    {

        for (int i = 0; i < list.Count; i++)
        {
            if (list.Count==i+1)
            {
                Console.Write("{0}", list[i]);
                break;
            }
            Console.Write("{0}, ", list[i]);

        }
        Console.WriteLine();
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            bool checker = true;
            if (i == 0 || i == 1)
            {
                checker = false;
            }
            for (long j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    checker = false;
                    break;
                }
            }
            if (checker==true)
            {
                primes.Add(i);
            }
        }
        return primes;
    }
}



