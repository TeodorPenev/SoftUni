using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string allSeq = Console.ReadLine();
            string[] seq = allSeq.Split(' ');
            List<string> sequence = new List<string>();
            sequence = seq.ToList();

            for (int i = 0; i < seq.Length-1; i++)
            {
                if (seq[i]==seq[i+1])
                {
                    Console.Write("{0} ",seq[i]);
                    if (i == seq.Length - 2)
                    {
                        Console.Write("{0} ", seq[i]);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ", seq[i]);
                    if (i == seq.Length-2)
                    {
                        Console.WriteLine("{0} ", seq[i + 1]);
                    } 
                }
            }
        }
    }
}
