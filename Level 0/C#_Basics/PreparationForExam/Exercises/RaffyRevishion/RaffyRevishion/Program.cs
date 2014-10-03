using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffyRevishion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Въведете сутрешния грамаж:");
            decimal sumMorning = 0;
            decimal sumEvening = 0;
            decimal sumFunelM = 0;
            decimal sumFunelE = 0;
            decimal moneyCase = 0;
            for (int i = 0; i <= 14; i++)
            {
                if (i>11)
                {
                    Console.WriteLine("Моля въведете грамаж за фунийки:");
                    decimal f =decimal.Parse(Console.ReadLine());
                    sumFunelM = sumFunelM + f;
                }
                else if (i<12)
                {
                    decimal n = decimal.Parse(Console.ReadLine());
                    sumMorning = sumMorning + n;
                } 
            }
            Console.WriteLine("Сътрешния грамаж е : {0:0.000} кг.",sumMorning+sumFunelM);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Моля въведете вечерния си грамаж:");
            for (int i = 0; i <= 14; i++)
            {
                if (i > 11)
                {
                    Console.WriteLine("Моля въведете грамаж за фунийки:");
                    decimal f = decimal.Parse(Console.ReadLine());
                    sumFunelE = sumFunelE + f;
                }
                else if (i<12)
                {
                    decimal n = decimal.Parse(Console.ReadLine());
                    sumEvening = sumEvening + n;
                }
                
            }
            Console.WriteLine("Вечерния грамаж е : {0:0.000} кг.", sumEvening+sumFunelE);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Продадения грамаж : {0:0.000} кг.",(sumMorning+sumFunelM)-(sumEvening+sumFunelE));
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            moneyCase = ((sumMorning + sumFunelM) - (sumEvening + sumFunelE)) * decimal.Parse("14.90");
            Console.WriteLine("Оборот : {0:00.00} лв.", moneyCase);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.ReadLine();  
        }
    }
}
