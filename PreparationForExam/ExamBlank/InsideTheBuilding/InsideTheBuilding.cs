using System;
class InsideTheBuilding
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (((x>=0) && (x<=size*3) && (y>=0) && (y<=size)) || ((x>=size) && (x<=size*2) && (y>=0) && (y<=size*4)))
            {
                Console.WriteLine("inside");
            }
            else

                Console.WriteLine("outside");
        }
    }
}