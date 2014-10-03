using System;
class LongestWordInAText
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] insertText = text.Split(' ');
        string empty = "";
        string[] compare = empty.Split(' ');
        
        for (int i = 0; i < insertText.Length; i++)
        {
            if (insertText[i].Length>compare[0].Length)
            {
                compare[0] = insertText[i];
            }
        }
        Console.WriteLine(compare[0]);
    }
}

