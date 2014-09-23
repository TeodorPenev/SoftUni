using System;
class LongestAreaInArray
{
    static void Main()
    {
        int nLenght = int.Parse(Console.ReadLine());
        string[] elements = new string[nLenght];
        int count = 0;
        int maxSuqence=0;
        string value = "";
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = Console.ReadLine();
        }
        Console.WriteLine();
        for (int j = 0; j < elements.Length; j++)
        {
            if (elements[j] == elements[j++])
            {
                count++;
                if (maxSuqence<count)
                {
                    maxSuqence = count;
                    value = elements[j];
                }
            }            
        }
        Console.WriteLine(maxSuqence);
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(value);
        }
        
    }
}

