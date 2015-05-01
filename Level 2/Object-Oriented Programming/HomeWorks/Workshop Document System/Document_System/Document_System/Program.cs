﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    class Program
    {
        static void Main()
        {
            //Document doc = new Document();
            ////doc.Add(new Paragraph("I am a paragraph"));
            //Color my = Color.Blue;
            //Console.WriteLine(my.GreenValue);
            //my.GreenValue = 112;
            //Console.WriteLine(my.GreenValue);
            //Color other = Color.Blue;
            //Console.WriteLine(other.GreenValue);

            Document doc = new Document();
            doc.Title = "My First Document";
            doc.Author = "Tedo";
            doc.Add(new Paragraph("I am a ninja"));
            doc.Add(new Paragraph("I am programmer ninja"));
            doc.RenderHtml(Console.Out);
            Console.WriteLine(doc.AsHTML);

            Paragraph numP = new Paragraph();
            numP.Add(new TextElement("First"));
            numP.Add(new TextElement("Second"));
            numP.Add(new TextElement("Third"));
            doc.Add(numP);

            doc.RenderHtml(Console.Out);
            File.WriteAllText("document.html", doc.AsHTML);


        }
    }
}