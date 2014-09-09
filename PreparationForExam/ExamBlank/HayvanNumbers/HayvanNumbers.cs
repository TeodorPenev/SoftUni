using System;
class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        string first = "";
        int abc = 0;
        int def = 0;
        int ghi = 0;
        string wholeSeq = "";
        int sumSeq = 0;
        bool exist = false;

        for (int a = 5; a < 10; a++)
        {
            for (int b = 5; b < 10; b++)
            {
                for (int c = 5; c < 10; c++)
                {
                    first = "" + a + b + c;
                    abc = int.Parse(first);
                    def = abc + diff;
                    ghi = def + diff;
                    wholeSeq = "" + abc + def + ghi;
                    if (((wholeSeq.Contains("0") || (wholeSeq.Contains("1")) || ((wholeSeq.Contains("2") || (wholeSeq.Contains("3")) || ((wholeSeq.Contains("4"))))))))
                    {
                        continue;
                    }
                    for (int i = 0; i < wholeSeq.Length; i++)
                    {
                        int tempN = int.Parse(wholeSeq[i].ToString());
                        sumSeq = sumSeq + tempN;
                    }
                    if (sum == sumSeq)
                    {
                        exist = true;
                        Console.WriteLine(wholeSeq);
                    }
                    sumSeq = 0;
                }
            }
        }
        if (exist == false)
        {
            Console.WriteLine("No");
        }
    }
}

