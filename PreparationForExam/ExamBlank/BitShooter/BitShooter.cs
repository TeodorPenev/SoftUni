using System;
namespace _5.BitShooter
{
    class BitShooter
    {
        static void Main()
        {
            ulong num = ulong.Parse(Console.ReadLine());
            ulong one = 1UL;
            int countR = 0;
            int countL = 0;
            ulong mask = 0;
            for (int i = 0; i < 3; i++)
            {
                string[] sCenterSize = Console.ReadLine().Split(' ');
                int center = int.Parse(sCenterSize[0]);
                int size = int.Parse(sCenterSize[1]);
                int posIncrease = center;
                for (int s = 0; s < size / 2 + 1 && posIncrease >= 0 && posIncrease < 64; s++)
                {
                    mask = one << posIncrease;
                    num = num & ~(mask);
                    posIncrease++;
                }
                posIncrease = center;
                for (int s = 0; s < size / 2 + 1 && posIncrease >= 0 && posIncrease < 64; s++)
                {
                    mask = one << posIncrease;
                    num = num & ~(mask);
                    posIncrease--;
                }
                posIncrease = center;
            }
            for (int i = 0; i <= 31; i++)
            {
                if ((num & one << i) >> i > 0)
                {
                    countR++;
                }
            }
            for (int i = 63; i >= 32; i--)
            {
                if ((num & one << i) >> i > 0)
                {
                    countL++;
                }
            }
            Console.WriteLine("left: {0}", countL);
            Console.WriteLine("right: {0}", countR);

        }
    }
}
