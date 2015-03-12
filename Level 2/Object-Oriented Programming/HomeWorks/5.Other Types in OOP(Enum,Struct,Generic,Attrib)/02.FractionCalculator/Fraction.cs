using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator,long denominator):this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set {
                if (value==0)
                {
                    throw new ArgumentException("The dominator cannot be 0!");
                }
                this.denominator = value; }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            long numerator = fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator;
            long denominator = fraction1.Denominator * fraction2.Denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            long numerator = fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator;
            long denominator = fraction1.Denominator * fraction2.Denominator;

            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("{0}\n",(decimal)this.numerator / (decimal)this.denominator));
            return result.ToString();
        }
    }
}
