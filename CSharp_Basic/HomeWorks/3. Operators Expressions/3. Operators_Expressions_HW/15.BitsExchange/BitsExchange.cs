using System;
class BitsExchange
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long firstBits = 0;
        long secondBits = 0;
        long firstMask = 0;
        long secondMask = 0;
        long cleanMaskF =0;
        long cleanMaskS = 0;
        firstMask = 7 << 3;
        firstBits = n & firstMask;
        firstBits = firstBits >> 3;
        secondMask = 7 << 24;
        secondBits = n & secondMask;
        secondBits = secondBits >> 24;
        cleanMaskF = ~(7 << 3) ;
        n = n & cleanMaskF;
        cleanMaskS = ~(7 << 24);
        n = n & cleanMaskS;
        n = n | secondBits << 3;
        n = n | firstBits << 24;

        Console.WriteLine(n);
    }
}

