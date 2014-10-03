using System;
using System.Numerics;
class CalculateNumberOfCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorielNDevK = 1;
        BigInteger factorielSub = 1;
        BigInteger NsubK = n - k;
        for (int i = n; i > k; i--)
        {
            factorielNDevK = factorielNDevK * i;
        }
        for (int i = 1; i <= NsubK; i++)
        {
            factorielSub = factorielSub * i;
        }
        Console.WriteLine("{0}", factorielNDevK / factorielSub);
    }
}

