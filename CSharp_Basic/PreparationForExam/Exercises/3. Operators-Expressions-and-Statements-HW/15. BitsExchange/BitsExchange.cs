//Problem 15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;
using System.Text;
class BitsExchange
{
    
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int firstBits = n1 & 7 << 3;
        firstBits = firstBits >> 3;
        int secondBits = n1 & 7 << 24;
        secondBits = secondBits >> 24;
        n1 = n1 & ~(7 << 3);
        n1 = n1 & ~(7 << 24);
        n1 = n1 | secondBits << 3;
        n1 = n1 | firstBits << 24;
        Console.WriteLine(n1);
    }
}

