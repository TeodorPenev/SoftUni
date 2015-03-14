using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.AsynchronousTimer
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Action method = () => Console.WriteLine("--->");
            AsyncTimer timer = new AsyncTimer(method, 15 , 1500);

            int ticks = timer.Ticks;
            Console.WriteLine("Try to throw arrow to right corner(use space)...you have {0} arrow!", ticks);
            
            Console.ReadLine();
        }            
    }
}
