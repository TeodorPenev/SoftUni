using System;
using System.Collections.Generic;
class SortingNumbers
{
    static void Main()
    {
        int nLight = int.Parse(Console.ReadLine());
        int[] numbers = new int[nLight];
        for (int i = 0; i < nLight; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
          
        }
        Array.Sort(numbers);
        Console.WriteLine();
        for (int j = 0; j <nLight; j++)
        {
            Console.WriteLine(numbers[j]);
        }
    }
}

