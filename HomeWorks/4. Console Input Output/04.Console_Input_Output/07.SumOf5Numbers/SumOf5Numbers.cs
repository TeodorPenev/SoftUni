using System;
namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Console.Write("Please numbers : ");
            string[] numsS = Console.ReadLine().Split(' ');
            double[] numsI = new double[numsS.Length];
            double sum = 0;
            for (int i = 0; i < numsS.Length; i++)
            {
                numsI[i] = double.Parse(numsS[i]);
                sum = sum + numsI[i];
            }
            Console.WriteLine("Sum = {0}",sum);
        }
    }
}
