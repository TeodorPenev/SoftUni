using System;
class ModifyABitAtGivenPos
{
    static void Main()
    {
        Console.Write("Please enter integer number : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter index position of bit : ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter desire value of bit : ");
        int v = int.Parse(Console.ReadLine());
        int mask = 0;
        if (v==0)
        {
            mask = ~(1 << p);
            n = n & mask;
        }
        if (v==1)
        {
            mask = 1 << p;
            n = n | mask;
        }
        Console.WriteLine("Result = {0}",n);
    }
}

