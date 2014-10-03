using System;
using System.Collections.Generic;
class FiveSpecialLetters
{
    static void Main()
    {
        string[] letters = new string[] { "a", "b", "c", "d", "e" };
        string wholeLetters = "";
        string tempResize = "";
        int startInput = int.Parse(Console.ReadLine());
        int endInput = int.Parse(Console.ReadLine());
        List<string> sorting = new List<string> { };
        int countSort = 0;
        bool exist = false;
        bool a = false;
        bool b = false;
        bool c = false;
        bool d = false;
        bool e = false;
        int sum = 0;
        if ((startInput < -10000 || startInput > 10000) || (endInput < -10000 || endInput > 10000))
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int m = 0; m < 5; m++)
                            {
                                wholeLetters = "" + letters[i] + letters[j] + letters[k] + letters[l] + letters[m];
                                a = false;
                                b = false;
                                c = false;
                                d = false;
                                e = false;
                                for (int n = 0; n < 5; n++)
                                {
                                    if (a == true && wholeLetters[n] == 'a')
                                    {
                                        continue;
                                    }
                                    if (b == true && wholeLetters[n] == 'b')
                                    {
                                        continue;
                                    }
                                    if (c == true && wholeLetters[n] == 'c')
                                    {
                                        continue;
                                    }
                                    if (d == true && wholeLetters[n] == 'd')
                                    {
                                        continue;
                                    }
                                    if (e == true && wholeLetters[n] == 'e')
                                    {
                                        continue;

                                    }
                                    if (wholeLetters[n] == 'a')
                                    {
                                        a = true;
                                        tempResize = tempResize + "" + wholeLetters[n];
                                        continue;
                                    }
                                    if (wholeLetters[n] == 'b')
                                    {
                                        b = true;
                                        tempResize = tempResize + "" + wholeLetters[n];
                                        continue;
                                    }
                                    if (wholeLetters[n] == 'c')
                                    {
                                        c = true;
                                        tempResize = tempResize + "" + wholeLetters[n];
                                        continue;
                                    }
                                    if (wholeLetters[n] == 'd')
                                    {
                                        d = true;
                                        tempResize = tempResize + "" + wholeLetters[n];
                                        continue;
                                    }
                                    if (wholeLetters[n] == 'e')
                                    {

                                        e = true;
                                        tempResize = tempResize + "" + wholeLetters[n];
                                        continue;
                                    }
                                }
                                int count = 1;
                                foreach (char letter in tempResize)
                                {
                                    if (letter == 'a')
                                    {
                                        sum = sum + count * 5;
                                        count++;
                                        continue;
                                    }
                                    if (letter == 'b')
                                    {
                                        sum = sum + count * (-12);
                                        count++;
                                        continue;
                                    }
                                    if (letter == 'c')
                                    {
                                        sum = sum + count * 47;
                                        count++;
                                        continue;
                                    }
                                    if (letter == 'd')
                                    {
                                        sum = sum + count * 7;
                                        count++;
                                        continue;
                                    }
                                    if (letter == 'e')
                                    {
                                        sum = sum + count * (-32);
                                        count++;
                                        continue;
                                    }

                                }
                                if (sum >= startInput && sum <= endInput)
                                {
                                    exist = true;
                                    sorting.Add(wholeLetters);
                                    sorting.Sort();
                                    Console.Write("{0} ", sorting[countSort]);
                                    countSort++;
                                }
                                tempResize = "";
                                sum = 0;
                            }
                        }
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



