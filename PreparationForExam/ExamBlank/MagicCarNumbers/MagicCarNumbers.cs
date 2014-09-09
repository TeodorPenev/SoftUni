using System;
class MagicCarNumbers
{
    static void Main()
    {
        int requestSum = int.Parse(Console.ReadLine()); ;
        int sum1 = 0;
        string sum1S = "";
        int chSum = 0;
        string wholeLetters = "";
        int count = 0;
        string[] letters = new string[] { "A", "B", "C", "E", "H", "K", "M", "P", "T", "X" };

        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 0; d <= 9; d++)
                        //aaaa", "abbb", "aaab", "aabb", "abab" and "abba", 
                        if (((a == b) && (b == c) && (c == d)) || ((a != b) && (b == c) && (c == d)) || ((a == b) && (b == c) && (c != d)) || ((a == b) && (b != c) && (c == d)) || ((a != b) && (a == c) && (b == d)) || ((a != b) && (b == c) && (a == d)))
                        {
                            sum1 = a + b + c + d;

                            sum1S = "" + a + b + c + d;

                            for (int i = 0; i < letters.Length; i++)
                            {
                                for (int j = 0; j < letters.Length; j++)
                                {
                                    wholeLetters = "" + letters[i] + letters[j];
                                    foreach (char ch in wholeLetters)
                                    {
                                        if (ch == 'A')
                                        {
                                            chSum = chSum + 10;
                                        }
                                        if (ch == 'B')
                                        {
                                            chSum = chSum + 20;
                                        }
                                        if (ch == 'C')
                                        {
                                            chSum = chSum + 30;
                                        }
                                        if (ch == 'E')
                                        {
                                            chSum = chSum + 50;
                                        }
                                        if (ch == 'H')
                                        {
                                            chSum = chSum + 80;
                                        }
                                        if (ch == 'K')
                                        {
                                            chSum = chSum + 110;
                                        }
                                        if (ch == 'M')
                                        {
                                            chSum = chSum + 130;
                                        }
                                        if (ch == 'P')
                                        {
                                            chSum = chSum + 160;
                                        }
                                        if (ch == 'T')
                                        {
                                            chSum = chSum + 200;
                                        }
                                        if (ch == 'X')
                                        {
                                            chSum = chSum + 240;
                                        }
                                    }
                                    if (40 + sum1 + chSum == requestSum)
                                    {
                                        count++;
                                    }
                                    chSum = 0;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                }
            }
        }
        Console.WriteLine(count);
    }


}

