using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upFak = 2 * n;
        BigInteger upFakRes = 1;
        int downFak = n + 1;
        BigInteger downFakRes = 1;
        BigInteger nRes = 1;
        BigInteger result = 0;
        for (int i = 1; i <= upFak; i++)
        {
            upFakRes = upFakRes * i;
        }

        for (int i = 1; i <= downFak; i++)
        {
            downFakRes = downFakRes * i;
        }
        for (int i = 1; i <= n; i++)
        {
            nRes = nRes * i;
        }
        result = upFakRes / downFakRes / nRes;
        Console.WriteLine(result);
    }
}

