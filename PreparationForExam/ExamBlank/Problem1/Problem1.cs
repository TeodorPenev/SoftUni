using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem1
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double v = double.Parse(Console.ReadLine());


        for (int i = 0; i <= 8; i++)
        {
            if (i==0 && (x==0 && y==0))
            {
                Console.WriteLine(Math.Pow(v,1));
                break;
            }

            if (i == 1 && (x == 1 && y == 0))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 2));
                break;
            }
            if (i == 2 && (x == 2 && y == 0))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 3));
                break;
            }
            if (i == 3 && (x == 0 && y == 1))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 4));
                break;
            }
            if (i == 4 && (x == 1 && y == 1))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 5));
                break;
            }
            if (i == 5 && (x == 2 && y == 1))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 6));
                break;
            }
            if (i == 6 && (x == 0 && y == 2))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 7));
                break;
            }
            if (i == 7 && (x == 1 && y == 2))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 8));
                break;
            }
            if (i == 8 && (x == 2 && y == 2))
            {
                v = v + i;
                Console.WriteLine(Math.Pow(v, 9));
                break;
            }
        }
    }
}

