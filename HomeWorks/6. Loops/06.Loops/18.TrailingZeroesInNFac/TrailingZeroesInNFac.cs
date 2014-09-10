using System;
using System.Numerics;
class TrailingZeroesInNFac
{
    static void Main()
    {
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        BigInteger loopsN = input;
        string temp="";
        int count = 0;
        for (int i = 1; i < loopsN; i++)
        {
            input = input * i;
        }
        temp = "" + input;
        for (int i = temp.Length-1; i>=0 ; i--)
        {
            if (temp[i]=='0')
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);
    }
}

