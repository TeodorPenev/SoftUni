using System;
namespace _3.ProgrammerDNA
{
    class ProgrammerDNA
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string ch = Console.ReadLine();
            string[] alpha = { "A", "B", "C", "D", "E", "F", "G" };
            int count = 0;
            for (int i = 0; i < alpha.Length; i++)
            {
                if (ch == alpha[i])
                {
                    count = i;
                }
            }
            string dot = new string('.', 3);
            for (int i = 0; i < n; i++)
            {
                dot = new string('.', 3);
                if (i % 7 == 0)
                {
                    dot = new string('.', 3);
                    Console.WriteLine(dot + alpha[count % 7] + dot);
                    count++;
                }
                if (i % 7 == 1)
                {
                    dot = new string('.', 2);
                    Console.WriteLine(dot + alpha[(count) % 7] + alpha[(count + 1) % 7] + alpha[(count + 2) % 7] + dot);
                    count += 3;
                }
                if (i % 7 == 2)
                {
                    dot = new string('.', 1);
                    Console.WriteLine(dot + alpha[(count) % 7] + alpha[(count + 1) % 7] + alpha[(count + 2) % 7] + alpha[(count + 3) % 7] + alpha[(count + 4) % 7] + dot);
                    count += 5;
                }
                if (i % 7 == 3)
                {
                    Console.WriteLine(alpha[(count) % 7] + alpha[(count + 1) % 7] + alpha[(count + 2) % 7] + alpha[(count + 3) % 7] + alpha[(count + 4) % 7] + alpha[(count + 5) % 7] + alpha[(count + 6) % 7]);
                    count += 7;
                }
                if (i % 7 == 4)
                {
                    dot = new string('.', 1);
                    Console.WriteLine(dot + alpha[(count) % 7] + alpha[(count + 1) % 7] + alpha[(count + 2) % 7] + alpha[(count + 3) % 7] + alpha[(count + 4) % 7] + dot);
                    count += 5;
                }
                if (i % 7 == 5)
                {
                    dot = new string('.', 2);
                    Console.WriteLine(dot + alpha[(count) % 7] + alpha[(count + 1) % 7] + alpha[(count + 2) % 7] + dot);
                    count += 3;
                }
                if (i % 7 == 6)
                {
                    dot = new string('.', 3);
                    Console.WriteLine(dot + alpha[count % 7] + dot);
                    count++;
                }
            }
























            //int n = int.Parse(Console.ReadLine());
            //string ch = Console.ReadLine();
            //char chConvert = (char)(ch[0]);
            //char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            //string dot1 = new string('.', 3);
            //string dot2 = new string('.', 2);
            //string dot3 = new string('.', 1);

            //int pos = 0;
            //;
            //for (int i = 0; i < alpha.Length; i++)
            //{
            //    if (chConvert == alpha[i])
            //    {
            //        pos = i;
            //    }
            //}
            //for (; n > 0; n = n - 7)
            //{
            //    if (n / 1 > 0)
            //    {
            //        //first          
            //        Console.WriteLine(dot1 + alpha[(pos) % 7] + dot1);
            //    }
            //    if (n / 2 > 0)
            //    {
            //        //second                
            //        Console.WriteLine(dot2 + alpha[(pos + 1) % 7] + alpha[(pos + 2) % 7] + alpha[(pos + 3) % 7] + dot2);
            //        pos = pos + 3;
            //    }
            //    if (n / 3 > 0)
            //    {
            //        //third                   
            //        Console.WriteLine(dot3 + alpha[(pos + 1) % 7] + alpha[(pos + 2) % 7] + alpha[(pos + 3) % 7] + alpha[(pos + 4) % 7] + alpha[(pos + 5) % 7] + dot3);
            //        pos = pos + 5;
            //    }
            //    if (n / 4 > 0)
            //        //four
            //        Console.WriteLine("" + alpha[(pos + 1) % 7] + alpha[(pos + 2) % 7] + alpha[(pos + 3) % 7] + alpha[(pos + 4) % 7] + alpha[(pos + 5) % 7] + alpha[(pos + 6) % 7] + alpha[(pos + 7) % 7]);
            //    pos = pos + 7;
            //    if (n / 5 > 0)
            //        //five
            //        Console.WriteLine(dot3 + alpha[(pos + 1) % 7] + alpha[(pos + 2) % 7] + alpha[(pos + 3) % 7] + alpha[(pos + 4) % 7] + alpha[(pos + 5) % 7] + dot3);
            //    pos = pos + 5;
            //    if (n / 6 > 0)
            //        //six
            //        Console.WriteLine(dot2 + alpha[(pos + 1) % 7] + alpha[(pos + 2) % 7] + alpha[(pos + 3) % 7] + dot2);
            //    pos = pos + 3;
            //    if (n / 7 > 0)
            //        //seven
            //        Console.WriteLine(dot1 + alpha[(pos + 1) % 7] + dot1);
            //    pos = pos + 2;
            //}

        }
    }
}
