using System;
using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare
{
    class MainClass

    {
        static void Main(string[] args)
        {
            Customer Tedy = new Customer("Teodor","Company");
            Customer Dani = new Customer("Daniel","Individual");

            DepositAccount d001 = new DepositAccount(Tedy,2200.20m,3);
            d001.Depositing(800);
            Console.WriteLine(d001);
            d001.Withdrawing(2000);
            Console.WriteLine(d001);
            d001.CalaculateInterest(2);
            Console.WriteLine(d001);

            LoanAccount d002 = new LoanAccount(Tedy,22,3);
            d002.Depositing(800);
            Console.WriteLine(d002);
            d002.CalaculateInterest(3);
            Console.WriteLine(d002);

            MortageAccount d003 = new MortageAccount(Tedy,2500,8);
            d003.Depositing(500.50m);
            Console.WriteLine(d003);
            d003.CalaculateInterest(13);
            Console.WriteLine(d003);
        }
    }
}
