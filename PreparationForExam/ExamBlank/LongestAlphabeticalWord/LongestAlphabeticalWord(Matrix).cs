using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

public class LongestAlphabeticalWord
{
    public static void Main()
    {
        string word = Console.ReadLine();
        int size = int.Parse(Console.ReadLine());
        char[,] matrix = new char[size, size];
        List<string> words = new List<string>() { };
        List<string> wordsLexi = new List<string>() { };

        // Fill the MATRIX
        int strIndex = 0;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = word[strIndex % word.Length];
                strIndex++;
            }


        }

        //Insert the matrix to prev
        char[,] prev = new char[size, size];

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                prev[row, col] = matrix[row, col];
            }
        }

        //Right Direction
        string longest = "";
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size - 1; col++)
            {
                if (matrix[row, col + 1] > prev[row, col])
                {
                    longest += "" + prev[row, col];
                }
                else
                {
                    longest += "" + prev[row, col];
                    words.Add(longest);
                    longest = "";
                }
                if (col == size - 1 - 1 && matrix[row, col + 1] > prev[row, col])
                {
                    longest += "" + prev[row, col + 1];
                    words.Add(longest);
                    longest = "";
                }
            }
            longest = "";
        }

        //Left Direction

        for (int row = 0; row < size; row++)
        {
            for (int col = size - 1; col > 0; col--)
            {
                if (matrix[row, col - 1] > prev[row, col])
                {
                    longest += "" + prev[row, col];
                }
                else
                {
                    longest += "" + prev[row, col];
                    words.Add(longest);
                    longest = "";
                }
                if ((col == 1) && (matrix[row, col - 1] > prev[row, col]))
                {
                    longest += "" + prev[row, col - 1];
                    words.Add(longest);
                    longest = "";
                }
            }
            longest = "";

        }
        //down Direction

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size - 1; row++)
            {
                if (matrix[row + 1, col] > prev[row, col])
                {
                    longest += "" + prev[row, col];
                }
                else
                {
                    longest += "" + prev[row, col];
                    words.Add(longest);
                    longest = "";
                }
                if ((matrix[row + 1, col] > prev[row, col]) && row + 2 == size)
                {
                    longest += "" + prev[row + 1, col];
                    words.Add(longest);
                    longest = "";
                }
            }
            longest = "";
        }

        // Up Direction
        for (int col = 0; col < size; col++)
        {
            for (int row = size - 1; row > 0; row--)
            {
                if (matrix[row - 1, col] > prev[row, col])
                {
                    longest += "" + prev[row, col];
                }
                else
                {
                    longest += "" + prev[row, col];
                    words.Add(longest);
                    longest = "";
                }
                if (row == 1 && (matrix[row - 1, col] > prev[row, col]))
                {
                    longest += "" + prev[row - 1, col];
                    words.Add(longest);
                    longest = "";
                }
            }
            longest = "";
        }

        int max = int.MinValue;
        for (int i = 0; i < words.Count; i++)
        {
            if (max < words[i].Length)
            {
                max = words[i].Length;

            }
        }
        for (int i = 0; i < words.Count; i++)
        {
            if (max == words[i].Length)
            {
                wordsLexi.Add(words[i]);
            }
        }
        wordsLexi.Sort();
        Console.WriteLine(wordsLexi[0]);


    }
}

