using System;
namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("Please enter unsigned integer : ");
            int bin = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int expr = bin & mask;
            int result = expr >> 3;
            Console.WriteLine("Bit #3 = {0}",result);
        }
    }
}
