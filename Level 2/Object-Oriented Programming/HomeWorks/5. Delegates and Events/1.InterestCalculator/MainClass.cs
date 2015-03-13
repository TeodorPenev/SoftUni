using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InterestCalculator
{
    internal class MainClass
    {
        static void Main()
        {
            InterestCalculator calcIterest001 = new InterestCalculator(2500, 7.2, 15, InterestType.simple);
            Console.WriteLine(calcIterest001.CalculateInterest());

            InterestCalculator calcInterest002 = new InterestCalculator(500, 5.6, 10, InterestType.compound);
            Console.WriteLine(calcInterest002.CalculateInterest());     
        }

    }

}
