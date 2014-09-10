using System;
class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Please enter mumber : ");
        int n = int.Parse(Console.ReadLine());
        bool devided = false;
        if (n%5 == 0 && n%7 == 0)
        {
            devided = true;
        }
        Console.WriteLine("Divided by 7 and 5? : {0}",devided);
    }   
}

