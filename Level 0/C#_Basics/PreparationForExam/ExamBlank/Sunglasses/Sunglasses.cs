﻿using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                string begin = new string('*', n * 2);
                string middle = new string(' ', n);
                Console.WriteLine("{0}{1}{0}", begin, middle);
            }
            else
            {
                if (i != n / 2)
                {
                    string mBegin = new string('/', n * 2 - 2);
                    string mMiddle = new string('*', 1);
                    string mBridge = new string(' ', n);
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", mMiddle, mBegin, mBridge);
                }
                if (i == n / 2)
                {
                    string mBegin = new string('/', n * 2 - 2);
                    string mMiddle = new string('*', 1);
                    string bridge = new string('|', n);
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", mMiddle, mBegin, bridge);
                }

            }
        }
    }
}