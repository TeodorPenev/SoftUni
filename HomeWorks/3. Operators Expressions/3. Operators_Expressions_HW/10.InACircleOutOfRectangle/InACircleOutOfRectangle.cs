using System;
class InACircleOutOfRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if (Math.Pow(x-1,2)+Math.Pow(y-1,2)<Math.Pow(1.5,2) && (x<-1 || x>5) || (y>1 || y<-1))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

