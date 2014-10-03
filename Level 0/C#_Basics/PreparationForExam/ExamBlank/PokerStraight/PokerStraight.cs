using System;
using System.Collections.Generic;

class PokerStraight
{
    static void Main()
    {
        int givenW = int.Parse(Console.ReadLine()); ;
        int ourW = 0;
        int count = 0;
        bool find = false;
        int[] wightS = new int[] { 1, 2, 3, 4 };
        int[] wightF = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        List<int> dublicateCheck = new List<int>();
        for (int i1 = 0; i1 <= 13; i1++)
        {
            for (int i2 = 0; i2 <= 13; i2++)
            {
                for (int i3 = 0; i3 <= 13; i3++)
                {
                    for (int i4 = 0; i4 <= 13; i4++)
                    {
                        for (int i5 = 0; i5 <= 13; i5++)
                        {
                            if ((wightF[i1] < wightF[i2]) && (wightF[i2] < wightF[i3]) && ((wightF[i3] < wightF[i4]) && (wightF[i4] < wightF[i5])) && (wightF[i1]==wightF[i2] -1 && (find == false)))
                            {
                                for (int s1 = 0; s1 <= 3; s1++)
                                {
                                    for (int s2 = 0; s2 <= 3; s2++)
                                    {
                                        for (int s3 = 0; s3 <= 3; s3++)
                                        {
                                            for (int s4 = 0; s4 <= 3; s4++)
                                            {
                                                for (int s5 = 0; s5 <= 3; s5++)
                                                {
                                                    ourW = (((10 * wightF[i1]) + wightS[s1]) + ((20 * wightF[i2]) + wightS[s2]) + ((30 * wightF[i3]) + wightS[s3]) + ((40 * wightF[i4]) + wightS[s4]) + ((50 * wightF[i5]) + wightS[s5]));
                                                    if (ourW == givenW)
                                                    {    
                                                        find = true;
                                                        count++;
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
            }
        }
        Console.WriteLine(count);
       
    }
}


