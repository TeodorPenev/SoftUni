using System;
class FitBoxInBox
{
    static void Main()
    {
        int firstD1 = int.Parse(Console.ReadLine());
        int firstD2 = int.Parse(Console.ReadLine());
        int firstD3 = int.Parse(Console.ReadLine());
        int secondD1 = int.Parse(Console.ReadLine());
        int secondD2 = int.Parse(Console.ReadLine());
        int secondD3 = int.Parse(Console.ReadLine());


        int sum1 = firstD1 + firstD2 + firstD3;
        int sum2 = secondD1 + secondD2 + secondD3;
        string smaller = "";

        if (sum1 < sum2)
        {
            smaller = "" + "(" + firstD1 + ", " + firstD2 + ", " + firstD3 + ")";
            if (firstD1 < secondD1 && firstD2 < secondD2 && firstD3 < secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, secondD1, secondD2, secondD3);
            }
            if (firstD1 < secondD1 && firstD2 < secondD3 && firstD3 < secondD2)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, secondD1, secondD3, secondD2);
            }
            if (firstD1 < secondD2 && firstD2 < secondD1 && firstD3 < secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, secondD2, secondD1, secondD3);
            }
            if (firstD1 < secondD2 && firstD2 < secondD3 && firstD3 < secondD1)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, secondD2, secondD3, secondD1);
            }
            if (firstD1 < secondD3 && firstD2 < secondD1 && firstD3 < secondD2)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, secondD3, secondD1, secondD2);
            }
            if (firstD1 < secondD3 && firstD2 < secondD2 && firstD3 < secondD1)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, secondD3, secondD2, secondD1);
            }
        }
        else if (sum1 > sum2)
        {
            smaller = "" + "(" + secondD1 + ", " + secondD2 + ", " + secondD3 + ")";

            if (firstD1 > secondD1 && firstD2 > secondD2 && firstD3 > secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, firstD1, firstD2, firstD3);
            }
            if (firstD1 > secondD1 && firstD3 > secondD2 && firstD2 > secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, firstD1, firstD3, firstD2);
            }
            if (firstD2 > secondD1 && firstD1 > secondD2 && firstD3 > secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, firstD2, firstD1, firstD3);
            }
            if (firstD2 > secondD1 && firstD3 > secondD2 && firstD1 > secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, firstD2, firstD3, firstD1);
            }
            if (firstD3 > secondD1 && firstD2 > secondD2 && firstD1 > secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, firstD3, firstD2, firstD1);
            }
            if (firstD3 > secondD1 && firstD1 > secondD2 && firstD2 > secondD3)
            {
                Console.WriteLine("{0} < ({1}, {2}, {3})", smaller, firstD3, firstD1, firstD2);
            }
        }

    }
}

