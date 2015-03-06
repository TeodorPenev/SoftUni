using _02.BankOfKurtovoKonare.Interfaces;
using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare
{
    class DepositAccount:Account,IDepositing,IWithdrawing,IInterestCalculable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public decimal Depositing(decimal deposit)
        {
            Balance = Balance + deposit;
            return Balance;
        }

        public decimal Withdrawing(decimal withdraw)
        {
            Balance = Balance - withdraw;
            return Balance;
        }

        public decimal CalaculateInterest(byte mounths)
        {
            Mounths = mounths;
            if (Balance>1000)
            {
                SpecificRate = Balance * (1 + (InterestRate / 100) * mounths);
            }
            return SpecificRate;
        }


    }
}
