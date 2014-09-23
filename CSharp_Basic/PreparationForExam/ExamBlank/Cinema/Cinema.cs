using System;
class Cinema
{
    static void Main()
    {
        string typeOfProjection = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        decimal income = 0;
        if (typeOfProjection == "Premiere")
        {
            income = (row * col) * 12;
            Console.WriteLine("{0:0.00} leva",income);
        }
        if (typeOfProjection == "Normal")
        {
            income = (decimal)((row * col) * 7.50);
            Console.WriteLine("{0:0.00} leva", income);
        }
        if (typeOfProjection == "Discount")
        {
            income = (row * col) * 5;
            Console.WriteLine("{0:0.00} leva", income);
        }
    }
}

