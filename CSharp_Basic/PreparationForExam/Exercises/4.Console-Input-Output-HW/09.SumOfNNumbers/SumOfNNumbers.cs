using System;

class SumOfNNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double result = 0;
        for (int i = 0; i < n; i++)
        {
            result += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum : {0}",result);
    }
}

