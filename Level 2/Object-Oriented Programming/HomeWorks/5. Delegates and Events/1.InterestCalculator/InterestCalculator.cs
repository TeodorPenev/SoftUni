using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InterestCalculator
{
    class InterestCalculator
    {
        private Func<double, double, double, string> funcMemory; 
        private double money;
        private double interest;
        private int years;

        public InterestCalculator(double money,double interest,int years,InterestType interestType)
        {
            this.money = money;
            this.interest = interest;
            this.years = years;
            this.InterestType = interestType;
        }

        public InterestType InterestType
        {
            set
            {
                if (value == InterestType.simple)
                {
                     this.funcMemory = GetSimpleInterest;
                    
                }
                else if (value == InterestType.compound)
                {
                    this.funcMemory = GetCompoundInterest;
                }
            }
        }

        public string CalculateInterest()
        {
            return funcMemory(this.money, this.interest, this.years);
        }

        private static string GetSimpleInterest(double sum, double interest, double years)
        {
            double calcInterest = interest / 100;
            double result = sum * (1 + calcInterest * years);
            string formatResult = String.Format("{0:#.0000}", result);
            return formatResult;
        }

        static string GetCompoundInterest(double sum, double interest, double years)
        {
            const double n = 12;
            double pow = n * years;
            double calcInterest = interest / 100;
            double result = sum * (Math.Pow(1 + calcInterest / n, pow));
            string formatResult = String.Format("{0:#.0000}", result);
            return formatResult;
        }
    }
}
