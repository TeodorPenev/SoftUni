//Problem 3.	Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
//n	Divided by 7 and 5?
//3	false
//0	false
//5	false
//7	false
//35	true
//140	true

using System;
class DivideBy7and5
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        bool r = n > 0 && (n % 7 == 0 && n % 5 == 0);
        Console.WriteLine(r);

    }
}

