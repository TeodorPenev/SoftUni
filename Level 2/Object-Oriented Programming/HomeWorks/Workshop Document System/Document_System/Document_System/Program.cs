using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Document_System
{
    class Program
    {
        static void Main()
        {
            Document doc = new Document();
            //doc.Add(new Paragraph("I am a paragraph"));
            Color my = Color.Blue;
            Console.WriteLine(my.GreenValue);
            my.GreenValue = 112;
            Console.WriteLine(my.GreenValue);
            Color other = Color.Blue;
            Console.WriteLine(other.GreenValue);
        }
    }
}
