using System;
using System.Collections.Generic;
using System.Linq;
class BullsAndCows
{
    static void Main()
    {
        List<string> secretL = new List<string> { };
        string secret = Console.ReadLine();
        int givenB = int.Parse(Console.ReadLine());
        int givenC = int.Parse(Console.ReadLine());
        string guest = "";
        bool exist = false;
        bool[] Bexist = new bool[4];
        bool[] Cexist = new bool[4];
        int countB = 0;
        int countC = 0;
        for (int i1 = 1; i1 < 10; i1++)
        {
            for (int i2 = 1; i2 < 10; i2++)
            {
                for (int i3 = 1; i3 < 10; i3++)
                {
                    for (int i4 = 1; i4 < 10; i4++)
                    {
                        guest = "" + i1 + i2 + i3 + i4;
                        for (int i = 0; i < 4; i++)
                        {
                            if (secret[i] == guest[i])
                            {
                                countB++;
                                Bexist[i] = true;
                            }
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if ((i!=j) && (secret[i] == guest[j]) && (Bexist[j] == false && Bexist[i] == false) && Cexist[j] == false)
                                {
                                    Cexist[j] = true;
                                    countC++;
                                    break;
                                }
                            }
                        }

                        if ((countB == givenB) && (countC == givenC))
                        {
                            exist = true;
                            secretL.Add(guest);
                        }
                        Cexist[0] = false;
                        Cexist[1] = false;
                        Cexist[2] = false;
                        Cexist[3] = false;
                        Bexist[0] = false;
                        Bexist[1] = false;
                        Bexist[2] = false;
                        Bexist[3] = false;
                        countB = 0;
                        countC = 0;
                    }
                }
            }
        }
        secretL.Sort();
        foreach (var code in secretL)
        {
            Console.Write(code + " ");
        }
        if (exist == false)
        {
            Console.WriteLine("No");
        }
    }
}

