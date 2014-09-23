using System;
class CatchTheBits
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int sequence = 0;
        int bitCount = 0;
        for (int i = 1, c = 1; i < num + 1; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            for (; c < 8 * i; c += step)
            {
                int pos = 7 - (c % 8);
                sequence = sequence << 1;
                sequence = sequence | ((currentNumber & (1 << pos)) >> pos);
                bitCount++;
                if (bitCount == 8)
                {
                    Console.WriteLine(sequence);
                    sequence = 0;
                    bitCount = 0;
                }
            }
        }
        if (bitCount > 0)
        {
            Console.WriteLine(sequence << 8 - bitCount);
        }
    }
}

