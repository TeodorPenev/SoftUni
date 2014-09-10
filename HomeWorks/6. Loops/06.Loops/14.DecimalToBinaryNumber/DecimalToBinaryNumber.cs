//int num = int.Parse(Console.ReadLine());
//Console.WriteLine(Convert.ToString(num, 2));
using System;
class DecimalToBinaryNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bit = 0;
        string bin = "";

        while (n>0)
        {
            bit = n % 2;
            n = n / 2;
            bin = bit + bin;
        }
        Console.WriteLine(bin);
    }
}

