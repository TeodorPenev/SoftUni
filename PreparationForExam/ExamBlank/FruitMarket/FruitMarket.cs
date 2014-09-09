using System;
class FruitMarket
{
    static void Main()
    {

        string dayOfWeek = Console.ReadLine();
        double sum1 = 0;
        double sum2 = 0;
        double sum3 = 0;
        double sum4 = 0;
        double sum5 = 0;
        double sum6 = 0;
        double sum7 = 0;
        //Friday
        if (dayOfWeek == "Friday")
        {
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if (product == "banana")
                {
                    sum5 = +sum5 + 1.80 * quantity;
                }
                if (product == "cucumber")
                {
                    sum5 = +sum5 + 2.75 * quantity;
                }
                if (product == "tomato")
                {
                    sum5 = +sum5 + 3.20 * quantity;
                }
                if (product == "orange")
                {
                    sum5 = +sum5 + 1.60 * quantity;
                }
                if (product == "apple")
                {
                    sum5 = +sum5 + 0.86 * quantity;
                }
            }
            if (dayOfWeek == "Friday")
            {
                sum5 = sum5 - (sum5 * 0.10);
                Console.WriteLine("{0:0.00}", sum5);
            }
        }
        //Sunday
        if (dayOfWeek == "Sunday")
        {
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if (product == "banana")
                {
                    sum7 = +sum7 + 1.80 * quantity;
                }
                if (product == "cucumber")
                {
                    sum7 = +sum7 + 2.75 * quantity;
                }
                if (product == "tomato")
                {
                    sum7 = +sum7 + 3.20 * quantity;
                }
                if (product == "orange")
                {
                    sum7 = +sum7 + 1.60 * quantity;
                }
                if (product == "apple")
                {
                    sum7 = +sum7 + 0.86 * quantity;
                }
            }
            if (dayOfWeek == "Sunday")
            {
                sum7 = sum7 - (sum7 * 0.05);
                Console.WriteLine("{0:0.00}", sum7);
            }

        }
        //Tuesday
        if (dayOfWeek == "Tuesday")
        {
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if (product == "banana")
                {
                    sum2 = +sum2 + (1.80 * quantity) - ((1.80 * quantity) * 0.20);
                }
                if (product == "cucumber")
                {
                    sum2 = +sum2 + 2.75 * quantity;
                }
                if (product == "tomato")
                {
                    sum2 = +sum2 + 3.20 * quantity;
                }
                if (product == "orange")
                {
                    sum2 = +sum2 + (1.60 * quantity) - ((1.60 * quantity) * 0.20);
                }
                if (product == "apple")
                {
                    sum2 = +sum2 + 0.86 * quantity - ((0.86 * quantity) * 0.20);
                }
            }
            if (dayOfWeek == "Tuesday")
            {

                Console.WriteLine("{0:0.00}", sum2);
            }

        }
        //Wednesday
        if (dayOfWeek == "Wednesday")
        {
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if (product == "banana")
                {
                    sum3 = +sum3 + 1.80 * quantity;
                }
                if (product == "cucumber")
                {
                    sum3 = +sum3 + (2.75 * quantity) - ((2.75 * quantity) * 0.10);
                }
                if (product == "tomato")
                {
                    sum3 = +sum3 + (3.20 * quantity) - ((2.75 * quantity) * 0.10);
                }
                if (product == "orange")
                {
                    sum3 = +sum3 + 1.60 * quantity;
                }
                if (product == "apple")
                {
                    sum3 = +sum3 + 0.86 * quantity;
                }
            }
            if (dayOfWeek == "Wednesday")
            {

                Console.WriteLine("{0:0.00}", sum3);
            }

        }

        //Thursday
        if (dayOfWeek == "Thursday")
        {
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if (product == "banana")
                {
                    sum4 = +sum4 + 1.80 * quantity - ((1.80 * quantity) * 0.30);
                }
                if (product == "cucumber")
                {
                    sum4 = +sum4 + 2.75 * quantity;
                }
                if (product == "tomato")
                {
                    sum4 = +sum4 + 3.20 * quantity;
                }
                if (product == "orange")
                {
                    sum4 = +sum4 + 1.60 * quantity;
                }
                if (product == "apple")
                {
                    sum4 = +sum4 + 0.86 * quantity;
                }
            }
            if (dayOfWeek == "Thursday")
            {

                Console.WriteLine("{0:0.00}", sum4);
            }
        }
        //Monday
        if (dayOfWeek == "Monday")
        {
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if (product == "banana")
                {
                    sum1 = +sum1 + 1.80 * quantity;
                }
                if (product == "cucumber")
                {
                    sum1 = +sum1 + 2.75 * quantity;
                }
                if (product == "tomato")
                {
                    sum1 = +sum1 + 3.20 * quantity;
                }
                if (product == "orange")
                {
                    sum1 = +sum1 + 1.60 * quantity;
                }
                if (product == "apple")
                {
                    sum1 = +sum1 + 0.86 * quantity;
                }
            }
            if (dayOfWeek == "Monday")
            {

                Console.WriteLine("{0:0.00}", sum1);
            }
        }
        //Saturday
        if (dayOfWeek == "Saturday")
        {
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if (product == "banana")
                {
                    sum6 = +sum6 + 1.80 * quantity;
                }
                if (product == "cucumber")
                {
                    sum1 = +sum6 + 2.75 * quantity;
                }
                if (product == "tomato")
                {
                    sum6 = +sum6 + 3.20 * quantity;
                }
                if (product == "orange")
                {
                    sum6 = +sum6 + 1.60 * quantity;
                }
                if (product == "apple")
                {
                    sum6 = +sum6 + 0.86 * quantity;
                }
            }
            if (dayOfWeek == "Saturday")
            {

                Console.WriteLine("{0:0.00}", sum6);
            }
        }
    }

}

