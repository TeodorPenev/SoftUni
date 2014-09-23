using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Please enter interger number : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter index position of bit : ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int expr = n & mask;
        int result = expr >> p;
        Console.WriteLine("Bit @ p =  {0}",result);
    }
}

