using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(fib(n));
    }
    static int fib(int n)
    {
        int a = 0;
        int b = 1;
        int fib = a + b;
        for (int i = 1; i < n; i++)
        {
            a = b;
            b = fib;
            fib = a + b;
        } 
        return fib;
    }
}

