using System;
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b && a > c) 
        {
            Console.Write("{0} ",a);
            if (b > c)
            {
                Console.Write("{0} {1} ",b,c);
            }
            if (c > b)
	        {
                Console.Write("{0} {1} ", c, b);
	        } 
            
        }
        if (b > a && b > c)
        {
            Console.Write("{0} ", b);
            if (a > c)
            {
                Console.Write("{0} {1} ", a, c);
            }
            if (c > a)
            {
                Console.Write("{0} {1} ", c, a);
            } 
        } 
        if (c > b && c > a)
        {
            Console.Write("{0} ", c);
            if (a >= b)
            {
                Console.Write("{0} {1} ", a, b);
            }
            if (b > a)
            {
                Console.Write("{0} {1} ", b, a);
            } 
        }
    }
}

