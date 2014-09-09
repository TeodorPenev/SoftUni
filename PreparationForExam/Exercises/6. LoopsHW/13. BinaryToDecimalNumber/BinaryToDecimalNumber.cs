//string bin = Console.ReadLine();
//Console.WriteLine(Convert.ToInt32(bin, 2));
    using System;
    class BinaryToDecimalNumber
{
        static void Main()
        {
            //string bin = Console.ReadLine();
            //long dec = 0;
            //int pow = bin.Length;
            //for (int i = 0 ; i<bin.Length ; i++)
            //{
            //    pow--;
            //    if (bin[i]=='0')
            //    {
            //        continue;
            //    }
            //    dec = (long)(dec + Math.Pow(2, pow));
            //}
            //Console.WriteLine(dec);

            {
                Console.Write("Enter your binary number: ");
                string binary = Console.ReadLine();
                long dec = 0;
                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[binary.Length - i - 1] == '0')
                    {
                        continue;
                    }

                    dec += (long)Math.Pow(2, i);
                }

                Console.WriteLine(dec);
            }
        }
        
}
