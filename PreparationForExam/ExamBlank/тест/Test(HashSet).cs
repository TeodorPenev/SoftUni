using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тест
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string a = Console.ReadLine();
            string[] abcSTR = new string[a.Length];                 
            HashSet<string> abcHASH = new HashSet<string>();
            
            for (int i = 0; i < a.Length; i++)
            {
                abcSTR[i] = a[i].ToString();                      //Put el in Array
            }

            for (int i = 0; i < abcSTR.Length; i++)
            {
                abcHASH.Add(abcSTR[i]);                           //Put in Hash
            }

            string[] Str = abcHASH.ToArray();                     //Convert Hash To Array
            for (int i = 0; i < Str.Length; i++)
            {
                Console.Write(Str[i]);
            }
            Console.WriteLine();
           


        //string[] letterSTR = Console.ReadLine().Split(' ');
        //var letterHASH = new HashSet<string>();                  //Unique data
        //int count = 0;
        //Array.Sort(letterSTR);
        
        //for (int i = 0; i < letterSTR.Length; i++)
        //{
        //    letterHASH.Add(letterSTR[i]);                        
        //}
        //string[] unique = letterHASH.ToArray();                   //Convert HashSet to Array

        //for (int i = 0; i < unique.Length; i++)
        //{
        //    for (int j = 0; j < letterSTR.Length; j++)
        //    {
        //        if (unique[i] == letterSTR[j])
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(unique[i] + " -> " + count);
        //    count = 0;
        }
    }
}
