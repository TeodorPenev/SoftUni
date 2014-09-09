using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Length of Fibonacci sequence: ");
        int length = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 1;
        if (length == 1)
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("0 ");
            Console.Write("1 ");
            Console.Write("1 ");
            for (int i = 0; i < length - 3; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
      
    }
}