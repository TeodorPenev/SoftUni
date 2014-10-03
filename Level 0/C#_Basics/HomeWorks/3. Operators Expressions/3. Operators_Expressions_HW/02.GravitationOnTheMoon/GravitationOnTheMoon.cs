using System;
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Please enter weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight on the Moon: {0}",weight*0.17);
        }
    }

