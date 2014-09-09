using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5.BitSiftingRestart
{
    class BitSifting
    {
        static void Main(string[] args)
        {
            ulong startN = ulong.Parse(Console.ReadLine());
            int nRead = int.Parse(Console.ReadLine());
            ulong one = 1;
            int count = 0;
            for (int i = 0; i < nRead; i++)
            {
                ulong readNumbers = ulong.Parse(Console.ReadLine());
                for (int j = 0; j < 63; j++)
                {
                    ulong res = readNumbers & (one << j);
                    if (res > 0)
                    {
                        startN = startN & ~(one << j);
                    }
                }
            }
            for (int k = 0; k < 63; k++)
            {
                if ((startN & one << k) > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
