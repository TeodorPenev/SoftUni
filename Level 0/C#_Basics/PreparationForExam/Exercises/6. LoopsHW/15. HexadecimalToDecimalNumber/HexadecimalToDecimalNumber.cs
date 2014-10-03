//string hexa = Console.ReadLine();
//Console.WriteLine(Convert.ToInt32(hexa, 16));
using System;
    class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A': number = number + 10 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'B': number = number + 11 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'C': number = number + 12 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'D': number = number + 13 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'E': number = number + 14 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'F': number = number + 15 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                default: number = number + (long)char.GetNumericValue(input[i]) * (long)Math.Pow(16, (input.Length - 1 - i)); break;
            }
        }
        Console.WriteLine(number);

    }
}

