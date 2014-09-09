using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] numS = Console.ReadLine().Split(' ');
        int numIEvenProd = 1;
        int numOddProd = 1;
        for (int i = 0; i < numS.Length; i++)
        {
            int numI = int.Parse(numS[i]);
            if (i % 2==0)
            {
                numIEvenProd =numIEvenProd*numI;

            }
            else if (i % 2 !=0)
            {
                numOddProd = numOddProd*numI;

            }
        }
        if (numIEvenProd==numOddProd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}",numIEvenProd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", numIEvenProd);
            Console.WriteLine("even_product = {0}", numOddProd );
        }
    }
}

