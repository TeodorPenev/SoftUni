using System;
class NumberAsWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstExt = n % 10;
        int secondExt = n % 100 / 10 - 2;
        int secondExtTo20 = n % 100;
        int thirdExt = n / 100;
        string hundred = "hundred";
        string[] firstN = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thrteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen ", "twenty" };
        string[] secondN = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };
        if (n == 100 || n == 200 || n == 300 || n == 400 || n == 500 || n == 600 || n == 700 || n == 800 || n == 900 || n == 1000)
        {
            Console.WriteLine("{0} {1}", firstN[thirdExt], hundred);

        }
        else
        {
            if (n <= 20)
            {
                Console.WriteLine(firstN[n]);
                return;
            }
            if (n < 100)
            {
                Console.WriteLine("{0} {1}", secondN[secondExt], firstN[firstExt]);
            }
            if (n % 100 < 20)
            {
                Console.WriteLine("{0} {1} {2}", firstN[thirdExt], hundred, firstN[secondExtTo20]);
            }
            if (n % 100 > 20)
            {
                Console.WriteLine("{0} {1} {2} {3}", firstN[thirdExt], hundred, secondN[secondExt], firstN[firstExt]);
            }
        }
    }
}

