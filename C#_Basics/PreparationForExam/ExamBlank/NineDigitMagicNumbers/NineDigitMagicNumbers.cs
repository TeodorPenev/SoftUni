using System;
namespace NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            string firstNS = "";
            int firstN = 0;
            int secondN = 0;
            int thirdN = 0;
            string wholeN = "";
            int ourSum = 0;
            bool exist = false;
            for (int i1 = 1; i1 < 8; i1++)
            {
                for (int i2 = 1; i2 < 8; i2++)
                {
                    for (int i3 = 1; i3 < 8; i3++)
                    {
                        firstNS = "" + i1 + i2 + i3;
                        firstN = int.Parse(firstNS);
                        secondN = firstN + diff;
                        thirdN = secondN + diff;
                        wholeN = "" + firstN + secondN + thirdN;
                        if ((wholeN.Contains("0") || (wholeN.Contains("8"))) || ((wholeN.Contains("9"))))
                        {
                            continue;
                        }
                        for (int i = 0; i < wholeN.Length; i++)
                        {
                            ourSum = ourSum + int.Parse(wholeN[i].ToString());
                        }
                        if (ourSum == sum)
                        {
                            exist = true;
                            Console.WriteLine(wholeN);
                        }
                        ourSum = 0;
                    }
                }
            }
            if (exist == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
