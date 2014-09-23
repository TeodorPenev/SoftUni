using System;
class LongestWordInAText
{
    static void Main()
    {
        string[] words = Console.ReadLine().Replace('.',' ').Split(' ');
        int longest = 0;
        string longestWord = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length>longest)
            {
                longest = words[i].Length;
                longestWord = words[i];
            }
        }
        Console.WriteLine(longestWord);
    }
}
