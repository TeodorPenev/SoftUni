using System;
using System.Numerics;
class TrailingZeroesinN
{
    static void Main()
    {
        BigInteger num = int.Parse(Console.ReadLine());
        BigInteger fakttoriel = 1;
        for (int i = 1; num>=i; i++)
        {
            fakttoriel = fakttoriel*i;
        }
        string subN = Convert.ToString(fakttoriel);
        int check=0;
        for (int i = 1; i < subN.Length; i++)
        {
            if (subN[subN.Length - i] == '0') 
            {
                check++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(check); 
    }

}

