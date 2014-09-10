using System;
class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double average = 0;

        for (int i = 0; i < n; i++)
        {
            double tempN = double.Parse(Console.ReadLine());
            if (tempN>max)
            {
                max = tempN;
            }
            if (tempN < min)
            {
                min = tempN;
            }
            sum = sum + tempN;
            average = sum / n;
        }
        Console.WriteLine("min = {0}",min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", average);

    }
}

