//string hexa = Console.ReadLine();
//Console.WriteLine(Convert.Tolong32(hexa, 16));
using System;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long pow = 0;
        long toDec = 0;
        long dec = 0;
       
            for (int i = hex.Length-1; i >=0 ; i--)
			{
                if (hex[i]=='A')
                {
                    dec = dec + 10 * (long)(Math.Pow(16, pow));
                }
                if (hex[i] == 'B')
                {
                    dec = dec + 11 * (long)(Math.Pow(16, pow));
                }
                if (hex[i] == 'C')
                {
                    dec = dec + 12 * (long)(Math.Pow(16, pow));
                }
                if (hex[i] == 'D')
                {
                    dec = dec + 13 * (long)(Math.Pow(16, pow));
                }
                if (hex[i] == 'E')
                {
                    dec = dec + 14 * (long)(Math.Pow(16, pow));
                }
                if (hex[i] == 'F')
                {
                    dec = dec + 15 * (long)(Math.Pow(16, pow));
                }
                if (!((hex[i] == 'A') || (hex[i] == 'B') || (hex[i] == 'C') || (hex[i] == 'D') || (hex[i] == 'E') || (hex[i] == 'F')))
                {
                    {
                        toDec = long.Parse(hex[i].ToString());
                        dec  = dec + toDec * ((long)(Math.Pow(16,pow)));
                    }
                } 
                pow++;
			}
            Console.WriteLine(dec);
    }
}
