using System;
class BitKiller
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int stepInput = int.Parse(Console.ReadLine());
        int result = 0;
        int countEnd = 0;
        int index = 0;


        for (int i = 0; i < numbers; i++)
        {
            int tempNum = int.Parse(Console.ReadLine());
            for (int t = 0; t < 8; t++)
            {
                if (index % stepInput == 1)                  //Repeat One Time Per StepInput 
                {
                    index++;
                    continue;
                }
                byte bit = (byte)((tempNum & 1 << 7 - t) >> 7 - t);
                result = result << 1;
                result = result | bit;
                countEnd++;

                index++;

                if (countEnd == 8)
                {
                    Console.WriteLine(result);
                    result = 0;
                    countEnd = 0;
                }
            }
        }
        if (countEnd > 0)
        {
            Console.WriteLine(result << 8 - countEnd);
        }

    }
}

