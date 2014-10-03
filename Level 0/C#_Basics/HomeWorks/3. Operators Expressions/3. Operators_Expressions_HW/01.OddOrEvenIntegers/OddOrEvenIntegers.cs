using System;
namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Please enter integer number : ");
            int n = int.Parse(Console.ReadLine());
            bool isOdd = true;
            if (n % 2 ==0)
            {
                isOdd = false;
            }
            Console.WriteLine("Odd? = {0}",isOdd);
        }
    }
}
