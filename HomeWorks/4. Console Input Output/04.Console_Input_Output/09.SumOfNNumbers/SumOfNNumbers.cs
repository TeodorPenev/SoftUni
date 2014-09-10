using System;
namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Please enter a number of n numbers: ");
            double n = double.Parse(Console.ReadLine());
            double sum =0;

            for (double i = 0; i < n; i++)
            {
                double nums = double.Parse(Console.ReadLine());
                sum += nums;
            }
            Console.WriteLine("Sum : {0}", sum);
        }
    }
}
