using System;
class Disk
{
    static void Main()
    {
    //    int fieldSize = int.Parse(Console.ReadLine());
    //    int radius = int.Parse(Console.ReadLine());
    //    int diskCenterRow = fieldSize / 2,
    //        diskCenterCol = fieldSize / 2;

    //    for (int currentRow = 0; currentRow < fieldSize; currentRow++)
    //    {
    //        for (int currentCol = 0; currentCol < fieldSize; currentCol++)
    //        {
    //            int deltaX = currentCol - diskCenterCol,
    //                deltaY = currentRow - diskCenterRow;
    //            double distanceToCenter = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    //            bool isWithinDisk = distanceToCenter <= radius;

    //            if (isWithinDisk)
    //            {
    //                Console.Write('*');
    //            }
    //            else
    //            {
    //                Console.Write('.');
    //            }
    //        }
    //        Console.WriteLine();
    //    }

        int size = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int centerX = size / 2;
        int centerY = size / 2;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                int deltaX = row - centerX;
                int deltaY = col - centerY;
                double distanceR = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                if (radius>=distanceR)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

    }
}


