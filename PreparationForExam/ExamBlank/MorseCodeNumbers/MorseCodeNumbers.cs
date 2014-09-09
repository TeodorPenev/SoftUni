using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.MorseCodeNumbers
{
    class MorseCodeNumbers
    {
        static void Main()
        {
            string n = Console.ReadLine();
            int nSum = 0;
            string product = "";
            bool exist = false;
            for (int i = 0; i < n.Length; i++)
            {
               string temp =n[i].ToString();
               nSum = nSum + int.Parse(temp);
            }
            for (int i1 = 0; i1 < 6; i1++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    for (int i3 = 0; i3 < 6; i3++)
                    {
                        for (int i4 = 0; i4 < 6; i4++)
                        {
                            for (int i5 = 0; i5 < 6; i5++)
                            {
                                for (int i6 = 0; i6 < 6; i6++)
                                {
                                    if (i1 * i2 * i3 * i4 * i5 * i6 == nSum)
                                    {
                                        product = "" + i1 + i2 + i3 + i4 + i5 + i6;
                                        
                                        for (int i = 0; i < product.Length; i++)
                                        {
                                            exist = true;

                                            if (product[i] == '0')
                                            {
                                                Console.Write("-----|");
                                            }
                                            if (product[i] == '1')
                                            {
                                                Console.Write(".----|");
                                            }
                                            if (product[i] == '2')
                                            {
                                                Console.Write("..---|");
                                            }
                                            if (product[i] == '3')
                                            {
                                                Console.Write("...--|");
                                            }
                                            if (product[i] == '4')
                                            {
                                                Console.Write("....-|");
                                            }
                                            if (product[i] == '5')
                                            {
                                                Console.Write(".....|");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                }
                            }
                        }
                    }
                }
            }
            if (exist == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
