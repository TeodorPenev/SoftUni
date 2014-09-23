using System;
namespace CrossingSequences
{
    class CrossingSequences
    {
        static void Main()
        {
            // Tribonachi Sequence
            //1, 2, 3, 6, 11, 20, 37, 68, 125, 230, 423, 778, 1431, 2632, 4841, 8904, 16377, 30122, 55403, 101902
            int n1 = int.Parse(Console.ReadLine()); ;
            int n2 = int.Parse(Console.ReadLine()); ;
            int n3 = int.Parse(Console.ReadLine()); ;
            int[] tribN = new int[10000];
            tribN[0] = n1;
            tribN[1] = n2;
            tribN[2] = n3;
            int tribCheck = 0;

            int TribSecFinal = 0;
            int SpiSecFinal = 0;

            string[] wholeTib = new string[10000];
            for (int i = 3; i < 10000; i++)
            {
                tribN[i] = n1 + n2 + n3;
                n1 = n2;
                n2 = n3;
                n3 = tribN[i];
                tribCheck = tribN[i];
                if (tribCheck > 1000000)
                {
                    break;
                }
                wholeTib[i] = "" + tribN[i];
            }

            // Spiral Sequence
            //5, 7, 9, 13, 17, 23, 29, 37
            int start = int.Parse(Console.ReadLine()); ;
            int step = int.Parse(Console.ReadLine()); ;
            int[] spiN = new int[10000];
            spiN[0] = start;
            int countStep = step;
            int spiNCheck = 0;
            for (int i = 1; i < 10000; i++)
            {
                spiNCheck = spiN[0];
                if (spiNCheck > 1000000)
                {

                    break;
                }
                spiN[i] = start + step;
                if (i % 2 == 0)
                {
                    step = step + countStep;
                }
                start = spiN[i];
                spiNCheck = spiN[i];
            }
            bool find = false;
            tribCheck = 0;
            spiNCheck = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (find == true)
                {
                    break;
                }
                if (tribCheck > 100000 || spiNCheck > 100000)
                {
                    break;
                }

                for (int j = 0; j < 10000; j++)
                {

                    TribSecFinal = tribN[i];
                    SpiSecFinal = spiN[j];
                    if (TribSecFinal == SpiSecFinal)
                    {

                        Console.WriteLine(TribSecFinal);
                        find = true;
                        break;
                    }

                }
            }
            if (find == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}
