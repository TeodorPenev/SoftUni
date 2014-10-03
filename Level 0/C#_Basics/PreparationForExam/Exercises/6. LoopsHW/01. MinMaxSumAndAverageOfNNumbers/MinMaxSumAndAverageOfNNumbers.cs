using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {

        double n = double.Parse(Console.ReadLine());
        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double n1Loop = 0;
        double average = 0;
           for (double i = 0; i < n; i++)
              {
                 double n1 = double.Parse(Console.ReadLine());
                 n1Loop = n1Loop + 1;
                  min = Math.Min(min, n1);
                  max = Math.Max(max, n1);
                  sum = sum + n1;
              }
           average = sum / n1Loop;
           Console.WriteLine("min = {0}",min);
           Console.WriteLine("max = {0}",max);
           Console.WriteLine("sum = {0}",sum);
           
           Console.WriteLine("avg = {0:0.00}",average);
           
    }
}

