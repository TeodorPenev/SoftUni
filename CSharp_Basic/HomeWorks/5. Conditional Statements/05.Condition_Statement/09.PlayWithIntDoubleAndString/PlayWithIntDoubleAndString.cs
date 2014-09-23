using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int type = int.Parse(Console.ReadLine());
        int choise1 = 0;
        double choise2 = 0;
        string choise3 = "";
        switch (type)
        {
            case 1: Console.WriteLine("Please enter a integer : ");
                choise1 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}",choise1+1);break;
            case 2: Console.WriteLine("Please enter a double : ");
                choise2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}", choise2 + 1); break;
            case 3: Console.WriteLine("Please enter a string : ");
                choise3 = Console.ReadLine();
                Console.WriteLine("{0}*", choise3); break;
            default: 
                break;
        }
    }
}

