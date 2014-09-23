//Problem 9.	Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

namespace _09.PrintSequence
{
    class PrintSequence
   {
        static void Main()
        {
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ",i);
                }
                else
                {
                    Console.Write("-{0}, ",i);
                }
            }

        }
    }
}

