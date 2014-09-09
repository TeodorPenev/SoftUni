using System;
class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] temp = new string[n];
        int count = 1;
        int maxCount = 1;
        int elPos = 0;
        
        for (int i = 0; i < n; i++)
        {
            temp[i] = Console.ReadLine();
        }

        for (int i = 0; i < n-1; i++)
        {
            if (temp[i] == temp[i + 1])
            {
                count++;
                if (maxCount < count)
                {
                    maxCount = count;
                    elPos = i;
                }
            }
            else
            {
                count = 1;
            }
        }

        Console.WriteLine(maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            Console.WriteLine(temp[elPos]);
        }
    }
}

