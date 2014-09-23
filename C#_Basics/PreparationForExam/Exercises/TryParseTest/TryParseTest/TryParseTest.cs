using System;
namespace TryParseTest
{
    class TryParseTest
    {
        static void Main()
        {
            int num1 = 0;
            Start: bool n1 = int.TryParse(Console.ReadLine(),out num1);
            if (n1==true)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine("You enter ivalid value.Please try again!");
                goto Start;
            }
            
        }
        
    }
}
