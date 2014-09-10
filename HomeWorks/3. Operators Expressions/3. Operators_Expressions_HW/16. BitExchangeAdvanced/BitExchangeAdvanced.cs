using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        long number = uint.Parse(Console.ReadLine());
        Console.Write("Please enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            int counterQ = q;
            for (int i = p; i <= p + k - 1; i++)
            {
                long mask = 1;
                long firstBits = ((mask << i) & number) >> i;//Get bit p
                long secondBits = ((mask << counterQ) & number) >> counterQ;//Get bit q
                number = number & ~(mask << i);//Convert bit p to 0
                number = number & ~(mask << counterQ);//Convert bit q to 0
                number = number | (secondBits << i);//Replace bit p with q
                number = number | (firstBits << counterQ);//Replace bit q with p
                counterQ++;
             }
            Console.WriteLine("Result = {0}",number);
        }
    }
}

