using System;
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please enter a number :");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n <= 0 || n==1)
        {
            isPrime = false;
        }
        for (int i = 2; i<n; i++)
        {
            if (n%i==0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine("The number isPrime = {0}",isPrime);
    }
}

