using System;
class Illuminati
{
    static void Main()
    {
        string message = Console.ReadLine().ToUpper();
        int countA = 0;
        int countE = 0;
        int countI = 0;
        int countO = 0;
        int countU = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] == 'A')
            {
                countA++;
            }
            if (message[i] == 'E')
            {
                countE++;
            }
            if (message[i] == 'I')
            {
                countI++;
            }
            if (message[i] == 'O')
            {
                countO++;
            }
            if (message[i] == 'U')
            {
                countU++;
            }
        }
        int numberOfVowels = countA + countE + countI + countO + countU;
        Console.WriteLine(numberOfVowels);
        int sumOfAllTheVowels = countA * 65 + countE * 69 + countI * 73 + countO * 79 + countU * 85;
        Console.WriteLine(sumOfAllTheVowels);
    }
}

