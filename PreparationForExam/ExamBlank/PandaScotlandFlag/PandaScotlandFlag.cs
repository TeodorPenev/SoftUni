using System;
class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countFlash = 0;
        int countTilda = 1;
        int countAlp = 2;
        string[] fAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        string flash = new string('#', n - 2);
        Console.WriteLine(fAlphabet[0] + flash + fAlphabet[1]);

        for (int i = 1; i < n / 2; i++)
        {
            string tilda = new string('~', countTilda);
            string inFlash = new string('#', (n - 4) - countFlash);
            Console.WriteLine(tilda + fAlphabet[countAlp % 26] + inFlash + fAlphabet[(countAlp + 1) % 26] + tilda);
            countTilda++;
            countFlash += 2;
            countAlp += 2;
        }
        string dash = new string('-', n / 2);
        Console.WriteLine(dash + fAlphabet[(n - 1) % 26] + dash);
        countAlp++;
        countTilda = 0;
        countFlash = 1;
        for (int i = 0; i < n / 2; i++)
        {
            string tilda = new string('~', (n - 3) / 2 - countTilda);
            string inFlash = new string('#', countFlash);
            Console.WriteLine(tilda + fAlphabet[countAlp % 26] + inFlash + fAlphabet[(countAlp+1) % 26 ] + tilda);
            countTilda++;
            countFlash += 2;
            countAlp += 2;
        }


    }
}

