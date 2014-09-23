using System;
using System.Collections.Generic;
using System.IO;
    class CountofNames
{
    static void Main()
    {
        Console.SetIn(new StreamReader("C:/Users/Teodor/Desktop/my.txt"));
        string[] names = Console.ReadLine().Split(' ');
        int count = 1;
        int countNum = 0;
        List<string> save = new List<string>();
        for (int i = 0; i < names.Length; i++)
        {
            save.Add(names[i]);
        }
        for (int j = 0; j < save.Count;j++) 
        {
            for (int i = 0; i < save.Count; i++)
            {
                if (save[j] == save[i])
                {
                    countNum++;
                    count++;
                    if (count > 2)
                    {
                        save.Remove(save[i]);
                        i--;
                        count = 1;
                    }
                }
            }
            Console.WriteLine("" + save[j] + " -> " + countNum);

            countNum  = 0;
        }
    }
}
