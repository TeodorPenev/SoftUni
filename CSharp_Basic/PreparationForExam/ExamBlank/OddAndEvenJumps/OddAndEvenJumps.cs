using System;
class OddAndEvenJumps
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        inputStr = inputStr.ToLower();
        inputStr = inputStr.Replace(" ", "");
        long oddJump = int.Parse(Console.ReadLine());
        long evenJump = int.Parse(Console.ReadLine());
        long oddSum = 0;
        long evenSum = 0;

        string oddLetters = "";
        string evenLetters = "";
        for (int i = 0; i < inputStr.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddLetters = "" + oddLetters + inputStr[i];
            }
            else
            {
                evenLetters = "" + evenLetters + inputStr[i];
            }

        }

        for (int i = 0; i < oddLetters.Length; i++)
        {


            if ((i + 1) % oddJump == 0)
            {
                oddSum = oddSum * oddLetters[i];
                continue;
            }
            oddSum = oddSum + oddLetters[i];
        }
        Console.WriteLine("Odd: {0}", Convert.ToString(oddSum, 16).ToUpper());

        for (int i = 0; i < evenLetters.Length; i++)
        {


            if ((i + 1) % evenJump == 0)
            {
                evenSum = evenSum * evenLetters[i];
                continue;
            }
            evenSum = evenSum + evenLetters[i];
        }
        Console.WriteLine("Even: {0}", Convert.ToString(evenSum, 16).ToUpper());
    }
}

