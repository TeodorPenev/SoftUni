using System;
using System.Collections.Generic;
class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        string wholeSeq = "";
        int[] wight = new int[] { 1, 3, 4, 5 };
        string finalSeq = "";
        List<string> alpha = new List<string>();
        bool exist = false;
        for (int s = 0; s < wight.Length; s++)
        {
            for (int n = 0; n < wight.Length; n++)
            {
                for (int k = 0; k < wight.Length; k++)
                {
                    for (int p = 0; p < wight.Length; p++)
                    {
                        for (int s1 = 0; s1 < wight.Length; s1++)
                        {
                            for (int n1 = 0; n1 < wight.Length; n1++)
                            {
                                for (int k1 = 0; k1 < wight.Length; k1++)
                                {
                                    for (int p1 = 0; p1 < wight.Length; p1++)
                                    {
                                        if (Math.Abs((wight[s] + wight[n] + wight[k] + wight[p]) - (wight[s1] + wight[n1] + wight[k1] + wight[p1])) == diff)
                                        {
                                            exist = true;
                                            wholeSeq = "" + wight[s] + wight[n] + wight[k] + wight[p] + wight[s1] + wight[n1] + wight[k1] + wight[p1];
                                            foreach (var ch in wholeSeq)
                                            {
                                                if (ch == '3')
                                                {
                                                    finalSeq += "" + "s";
                                                }
                                                if (ch == '4')
                                                {
                                                    finalSeq += "" + "n";
                                                }
                                                if (ch == '1')
                                                {
                                                    finalSeq += "" + "k";
                                                }
                                                if (ch == '5')
                                                {
                                                    finalSeq += "" + "p";
                                                }
                                            }
                                            exist = true;
                                            alpha.Add(finalSeq);
                                            finalSeq = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        alpha.Sort();
        for (int i = 0; i < alpha.Count; i++)
        {
            Console.WriteLine(alpha[i]);
        }
        if (exist == false)
        {
            Console.WriteLine("No");
        }
    }
}

