using System;
namespace BitsInverter
{
    class BitsInverter
    {
        static void Main()
        {
            byte num = byte.Parse(Console.ReadLine());
            byte step = byte.Parse(Console.ReadLine());

            for (int i = 1, c = 0; i < num+1; i++)
            {
                byte temp = byte.Parse(Console.ReadLine());
                for (; c < 8*i; c = c + step)
                {
                    byte pos = (byte)(7 - (c % 8));
                    byte mask = (byte)(1<<pos);
                    if ((temp & mask) >0)
                    {
                        temp = (byte)(temp & ~mask);             //Invert to 0
                    }
                    else
                    {
                        temp = (byte)(temp | mask);              //Invert to 1
                    }
                }
                Console.WriteLine(temp);
            }
        }
    }
}
