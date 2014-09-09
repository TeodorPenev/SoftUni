using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int" );
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        byte type = byte.Parse(Console.ReadLine());
        int intType = 0;
        double doubleType = 0;
        string stringType = "";
        switch (type)
        {
            case 1: intType = int.Parse(Console.ReadLine()); 
                intType++;
                Console.WriteLine(intType);
                break;
            case 2: doubleType = double.Parse(Console.ReadLine());
                doubleType++;
                Console.WriteLine(doubleType);
                break;
            case 3: stringType = Console.ReadLine();
                Console.WriteLine("{0}*",stringType);
                break;
            default:
                break;
        }
    }
}

