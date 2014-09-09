using System;
class MelonsAndWatermelons
{
    static void Main()
    {
        int startDay = int.Parse(Console.ReadLine());
        int sequenceDay = int.Parse(Console.ReadLine());
        int aMelons = 0;
        int aWaterMelons = 0;

        for (int i = 0; i < sequenceDay; i++)
        {
            if (startDay == 1)
            {
                aWaterMelons = aWaterMelons + 1;
                startDay = 2;
                continue;
            }
            if (startDay == 2)
            {
                aMelons = aMelons + 2;
                startDay = 3;
                continue;
            }
            if (startDay == 3)
            {
                aWaterMelons = aWaterMelons + 1;
                aMelons = aMelons + 1;
                startDay = 4;
                continue;
            }
            if (startDay == 4)
            {
                aWaterMelons = aWaterMelons + 2;
                startDay = 5;
                continue;
            }
            if (startDay == 5)
            {
                aWaterMelons = aWaterMelons + 2;
                aMelons = aMelons + 2;
                startDay = 6;
                continue;
            }
            if (startDay == 6)
            {
                aWaterMelons = aWaterMelons + 1;
                aMelons = aMelons + 2;
                startDay = 7;
                continue;
            }
            if (startDay == 7)
            {
                startDay = 1;
                continue;
            }
        }
        if (aMelons == aWaterMelons)
        {
            Console.WriteLine("Equal amount: {0}", aWaterMelons);
        }
        if (aMelons > aWaterMelons)
        {
            Console.WriteLine("{0} more melons", aMelons - aWaterMelons);
        }
        if (aWaterMelons > aMelons)
        {
            Console.WriteLine("{0} more watermelons", aWaterMelons - aMelons);
        }
    }
}

