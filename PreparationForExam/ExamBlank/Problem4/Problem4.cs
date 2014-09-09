using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem4
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        long sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char temCh = input[i];
            sum = sum + (temCh - 96);
        }
        for (long i1 = 0; i1 < 10; i1++)
        {
            for (long i2 = 0; i2 < 10; i2++)
            {
                for (long i3 = 0; i3 < 10; i3++)
                {
                    for (long i4 = 0; i4 < 10; i4++)
                    {
                        for (long i5 = 0; i5 < 10; i5++)
                        {
                            for (long i6 = 0; i6 < 10; i6++)
                            {
                                if (i1 * i2 * i3==i4 * i5 * i6)
                                {
                                    if (i1*i2*i3==sum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}",i1,i2,i3,i4,i5,i6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

