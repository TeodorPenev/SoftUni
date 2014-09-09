//string bin = Console.ReadLine();
//Console.WriteLine(Convert.ToInt32(bin, 2));
using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        for (; n2!= 0 && n1!=0;)
        {
            
            if (n1<n2)
            {
                n1 = n1 % n2;
                n2 = n2 % n1;
                
            }
            else
            {
                if (n2<n1)
                {
                    n2 = n2 % n1;
                    n1 = n1 % n2;   
                }
                
            }
        }
        if (n1>n2)
        {
            Console.WriteLine(n1);
        }
        else
        {
            Console.WriteLine(n2);
        }
        
    }
}
