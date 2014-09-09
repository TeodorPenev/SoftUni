using System;
namespace BitRoller
{
    class BitRoller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int positionFreaze = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < r; i++)
            {
                for (int pos = 0; pos < 19; pos++)
                {
                    int bit = (n >> pos & 1);
                    if (pos == positionFreaze)
                    {
                        result = result | (bit << pos);
                    }
                    else
                    {
                        int newPos = pos - 1;

                        if (newPos == positionFreaze)
                        {
                            newPos = newPos - 1;
                            result = result | (bit << newPos);
                            newPos = 0;
                            continue;
                        }
                        if (newPos < 0)
                        {
                            newPos = 18;
                            if (newPos == positionFreaze)
                            {
                                newPos = newPos - 1;
                            }
                            result = result | (bit << newPos);
                        }
                        else
                        {
                            result = result | (bit << pos - 1);
                        }
                    }
                }
                n = result;
                result = 0;
            }
            Console.WriteLine(n);
        }
    }
}

