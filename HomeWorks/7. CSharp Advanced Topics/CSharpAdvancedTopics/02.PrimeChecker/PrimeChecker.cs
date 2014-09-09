using System;
class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(isPrime(n));
    }
    static bool isPrime(long n)
    {
        bool checker = true;
        if (n==0 || n==1)
        {
            checker = false;
        }
        for (long i = 2; i < n; i++)
        {
            if (n%i==0)
            {
                checker=false;
                break;
            }
        }
        return checker;
    }
}

