using System;
class StudentCables
{
    static void Main()
    {
        int sum = 0;
        int countCable = 0;
        int joinedCable = 0;

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            int tempInt = int.Parse(Console.ReadLine());
            string tempStr = Console.ReadLine();
            if (tempStr == "meters")
            {
                tempInt = tempInt * 100;
            }
            if (tempInt < 20)
            {
                continue;
            }
            countCable++;

            sum = (sum + tempInt);

        }
        sum = sum - (3 * (countCable - 1));
        joinedCable = sum / 504;
        Console.WriteLine(joinedCable);
        Console.WriteLine(sum - (joinedCable * 504));
    }
}

