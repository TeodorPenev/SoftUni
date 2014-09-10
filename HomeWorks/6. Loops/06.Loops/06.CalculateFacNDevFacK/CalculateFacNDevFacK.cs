using System;
namespace _06.CalculateFacNDevFacK
{
    class CalculateFacNDevFacK
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            for (int i = n; i > k; i--)
            {
                factorialN = factorialN * i;
            }
            Console.WriteLine(factorialN);
        }
    }
}
