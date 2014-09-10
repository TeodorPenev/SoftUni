using System;
class CalculateGCD
{
    static void Main()
    {
        //First:

        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        while (num1 != 0 && num2 != 0)
        {
            if (num1 > num2)
            {
                num1 -= num2;
            }
            else
            {
                num2 -= num1;
            }
        }
        Console.WriteLine(Math.Max(num1, num2));
    }
}

        //Second:  

//        int n1 = int.Parse(Console.ReadLine());
//        int n2 = int.Parse(Console.ReadLine());
//        for (; n2 != 0 && n1 != 0; )
//        {

//            if (n1 < n2)
//            {
//                n1 = n1 % n2;
//                n2 = n2 % n1;

//            }
//            else
//            {
//                if (n2 < n1)
//                {
//                    n2 = n2 % n1;
//                    n1 = n1 % n2;
//                }

//            }
//        }
//        if (n1 > n2)
//        {
//            Console.WriteLine(n1);
//        }
//        else
//        {
//            Console.WriteLine(n2);
//        }
//    }
//}



