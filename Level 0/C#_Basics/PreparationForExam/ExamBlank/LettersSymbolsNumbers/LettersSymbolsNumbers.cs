using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class LettersSymbolsNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long lettersSum = 0;
        long symbolsSum = 0;
        long numbersSum = 0;

        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();

            // Convert the input to upper-case
            inputLine = inputLine.ToUpper();

            // Remove the whitespace from the input
            inputLine = Regex.Replace(inputLine, "\\s+", "");

            for (int k = 0; k < inputLine.Length; k++)
            {
                char currentChar = inputLine[k];
                if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    // Letters [a-zA-z]
                    lettersSum += (currentChar - 'A' + 1) * 10;
                }
                else if (currentChar >= '0' && currentChar <= '9')
                {
                    // Numbers [0-9]
                    numbersSum += (currentChar - '0') * 20;
                }
                else
                {
                    // Symbols
                    symbolsSum += 200;
                }
            }
        }

        Console.WriteLine(lettersSum);
        Console.WriteLine(numbersSum);
        Console.WriteLine(symbolsSum);

        //int n = int.Parse(Console.ReadLine());
        //List<string> seq = new List<string>(n);
        //int sumLetters = 0;
        //int sumSymbols = 0;
        //int sumNumbers = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    string input = Console.ReadLine();

        //    for (int k = 0; k < input.Length; k++)
        //    {
        //        if (input[k] == 'A' || input[k] == 'a')
        //        {
        //            sumLetters = sumLetters + 10;
        //        }
        //        if (input[k] == 'B' || input[k] == 'b')
        //        {
        //            sumLetters = sumLetters + 20;
        //        }
        //        if (input[k] == 'C' || input[k] == 'c')
        //        {
        //            sumLetters = sumLetters + 30;
        //        }
        //        if (input[k] == 'D' || input[k] == 'd')
        //        {
        //            sumLetters = sumLetters + 40;
        //        }
        //        if (input[k] == 'E' || input[k] == 'e')
        //        {
        //            sumLetters = sumLetters + 50;
        //        }
        //        if (input[k] == 'F' || input[k] == 'f')
        //        {
        //            sumLetters = sumLetters + 60;
        //        }
        //        if (input[k] == 'G' || input[k] == 'g')
        //        {
        //            sumLetters = sumLetters + 70;
        //        }
        //        if (input[k] == 'H' || input[k] == 'h')
        //        {
        //            sumLetters = sumLetters + 80;
        //        }
        //        if (input[k] == 'I' || input[k] == 'i')
        //        {
        //            sumLetters = sumLetters + 90;
        //        }
        //        if (input[k] == 'J' || input[k] == 'j')
        //        {
        //            sumLetters = sumLetters + 100;
        //        }
        //        if (input[k] == 'K' || input[k] == 'k')
        //        {
        //            sumLetters = sumLetters + 110;
        //        }
        //        if (input[k] == 'L' || input[k] == 'l')
        //        {
        //            sumLetters = sumLetters + 120;
        //        }
        //        if (input[k] == 'M' || input[k] == 'm')
        //        {
        //            sumLetters = sumLetters + 130;
        //        }
        //        if (input[k] == 'N' || input[k] == 'n')
        //        {
        //            sumLetters = sumLetters + 140;
        //        }
        //        if (input[k] == 'O' || input[k] == 'o')
        //        {
        //            sumLetters = sumLetters + 150;
        //        }
        //        if (input[k] == 'P' || input[k] == 'p')
        //        {
        //            sumLetters = sumLetters + 160;
        //        }
        //        if (input[k] == 'Q' || input[k] == 'q')
        //        {
        //            sumLetters = sumLetters + 170;
        //        }
        //        if (input[k] == 'R' || input[k] == 'r')
        //        {
        //            sumLetters = sumLetters + 180;
        //        }
        //        if (input[k] == 'S' || input[k] == 's')
        //        {
        //            sumLetters = sumLetters + 190;
        //        }
        //        if (input[k] == 'T' || input[k] == 't')
        //        {
        //            sumLetters = sumLetters + 200;
        //        }
        //        if (input[k] == 'U' || input[k] == 'u')
        //        {
        //            sumLetters = sumLetters + 210;
        //        }
        //        if (input[k] == 'V' || input[k] == 'v')
        //        {
        //            sumLetters = sumLetters + 220;
        //        }
        //        if (input[k] == 'W' || input[k] == 'w')
        //        {
        //            sumLetters = sumLetters + 230;
        //        }
        //        if (input[k] == 'X' || input[k] == 'x')
        //        {
        //            sumLetters = sumLetters + 240;
        //        }
        //        if (input[k] == 'Y' || input[k] == 'y')
        //        {
        //            sumLetters = sumLetters + 250;
        //        }
        //        if (input[k] == 'Z' || input[k] == 'z')
        //        {
        //            sumLetters = sumLetters + 260;
        //        }

        //        if ((input[k] == '`' || input[k] == '~') || (input[k] == '!' || input[k] == '~') || (input[k] == '@' || input[k] == '#') || (input[k] == '$' || input[k] == '%') || (input[k] == '^' || input[k] == '&') || (input[k] == '*' || input[k] == '(') || (input[k] == ')' || input[k] == '_') || (input[k] == '+' || input[k] == '{') || (input[k] == '}' || input[k] == ':') || (input[k] == '"' || input[k] == '|') || (input[k] == '<' || input[k] == '>') || (input[k] == '?' || input[k] == '-') || (input[k] == '=' || input[k] == '[') || (input[k] == ']' || input[k] == ';') || (input[k] == '\'' || input[k] == '\\') || (input[k] == ',' || input[k] == '.') || input[k] == '/')
        //        {
        //            sumSymbols = sumSymbols + 200;
        //        }
        //        if (input[k] == '0')
        //        {
        //            sumNumbers = sumNumbers + 0;
        //        }
        //        if (input[k] == '1')
        //        {
        //            sumNumbers = sumNumbers + 20;
        //        }
        //        if (input[k] == '2')
        //        {
        //            sumNumbers = sumNumbers + 40;
        //        }
        //        if (input[k] == '3')
        //        {
        //            sumNumbers = sumNumbers + 60;
        //        }
        //        if (input[k] == '4')
        //        {
        //            sumNumbers = sumNumbers + 80;
        //        }
        //        if (input[k] == '5')
        //        {
        //            sumNumbers = sumNumbers + 100;
        //        }
        //        if (input[k] == '6')
        //        {
        //            sumNumbers = sumNumbers + 120;
        //        }
        //        if (input[k] == '7')
        //        {
        //            sumNumbers = sumNumbers + 140;
        //        }
        //        if (input[k] == '8')
        //        {
        //            sumNumbers = sumNumbers + 160;
        //        }
        //        if (input[k] == '9')
        //        {
        //            sumNumbers = sumNumbers + 180;
        //        }

        //    }
        //}
        //Console.WriteLine(sumLetters);
        //Console.WriteLine(sumNumbers);
        //Console.WriteLine(sumSymbols);
    }
}

