using System;
using System.Collections.Generic;
using System.Linq;
class CountOfLetters
{
    static void Main()
    {
        string[] letters = Console.ReadLine().Split(' ');
        var letter = new HashSet<string>();                //Unique data
        int count = 0;
        Array.Sort(letters);
        
        for (int i = 0; i < letters.Length; i++)
        {
            letter.Add(letters[i]);                        
        }
        string[] unique = letter.ToArray();                //Convert HashSet to Array

        for (int i = 0; i < unique.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (unique[i] == letters[j])
                {
                    count++;
                }
            }
            Console.WriteLine(unique[i] + " -> " + count);
            count = 0;
        }
    }
}


