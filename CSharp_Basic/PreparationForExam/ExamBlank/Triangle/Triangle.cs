using System;
class Triangle
{
    static void Main()
    {
        double Ax = double.Parse(Console.ReadLine());
        double Ay = double.Parse(Console.ReadLine());
        double Bx = double.Parse(Console.ReadLine());
        double By = double.Parse(Console.ReadLine());
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());
        double distanceAB = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
        double distanceBC = Math.Sqrt(Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2));
        double distanceAC = Math.Sqrt(Math.Pow(Cx - Ax, 2) + Math.Pow(Cy - Ay, 2));
        double p = (distanceAB + distanceBC + distanceAC) / 2;
        double area = 0;
        if (distanceAB + distanceBC > distanceAC && distanceBC + distanceAC > distanceAB && distanceAB + distanceAC > distanceBC)
        {
            Console.WriteLine("Yes");
            area = Math.Sqrt(p * (p - distanceAB) * (p - distanceBC) * (p - distanceAC));
            Console.WriteLine("{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", distanceAB);
        }
    }
}

