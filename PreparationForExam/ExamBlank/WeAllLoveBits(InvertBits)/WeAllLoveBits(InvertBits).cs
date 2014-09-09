using System;

class Problem_5_We_All_Love_Bits
{
    static void Main()
    {
        // Read N
        int N = int.Parse(Console.ReadLine());

        // For all N numbers
        for (int i = 1; i <= N; i++)
        {
            // Read P
            int P = int.Parse(Console.ReadLine());

            // Solve
            int Pnew = 0;                   //Invert
            while (P > 0)                       
            {
                Pnew = Pnew << 1;
                if ((P & 1) == 1)
                {
                    Pnew = Pnew | 1;
                }
                P = P >> 1;
            }

            // Write Pnew
            Console.WriteLine(Pnew);
        }
    }
}

