using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
       
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}

