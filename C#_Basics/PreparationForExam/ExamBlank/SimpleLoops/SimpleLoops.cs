using System;
using System.Numerics;

class SimpleLoops
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger nNum = 0;
        if (n <= 3)
        {
            if (n == 1)
            {
                nNum = a;
            }
            if (n == 2)
            {
                nNum = b;
            }
            if (n == 3)
            {
                nNum = c;
            }
        }
        else
        {
            for (BigInteger i = 3; i < n; i++)
            {
                nNum = a + b + c;
                a = b;
                b = c;
                c = nNum;
            }
        }
        Console.WriteLine(nNum);

    }
}

