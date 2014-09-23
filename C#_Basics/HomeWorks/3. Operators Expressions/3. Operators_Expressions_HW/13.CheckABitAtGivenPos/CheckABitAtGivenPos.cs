using System;
class CheckABitAtGivenPos
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter index position of bit: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 0;
        int result = 0;
        bool IsOne = false;
        mask = 1 << p;
        n = n & mask;
        result = n >> p;
        if (result == 1)
        {
            IsOne = true;
        }
        Console.WriteLine("Bit @ p == 1 is : {0}", IsOne);
    }
}

