using System;
namespace BitsUp
{
    class BitsUp
    {
        static void Main()
        {
            byte num = byte.Parse(Console.ReadLine());
            byte step = byte.Parse(Console.ReadLine());

            for (int i = 1, c = 1; i < num + 1; i++)
            {
                byte temp = byte.Parse(Console.ReadLine());
                for (; c < 8 * i; c = c + step)
                {
                    byte pos = (byte)(7 - (c % 8));
                    temp = (byte)(temp | 1 << pos);
                }
                Console.WriteLine(temp);
            }
        }

    }
}
