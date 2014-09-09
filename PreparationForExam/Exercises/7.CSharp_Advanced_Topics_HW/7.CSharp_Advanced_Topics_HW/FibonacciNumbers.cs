using System;
class FibonacciNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 1;
        if (num == 0 || num == 1)
        {
            Console.WriteLine("1 ");
        }
        else
        {
            for (int i = 0; i < num -1; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            Console.WriteLine(c);
    }
}}

