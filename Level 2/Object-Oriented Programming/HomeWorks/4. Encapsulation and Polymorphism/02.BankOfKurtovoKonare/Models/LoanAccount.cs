
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    class LoanAccount:Account,IDepositing,IInterestCalculable
    {
        
        public LoanAccount(Customer customer,decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public decimal Depositing(decimal deposit)
        {
            Balance = Balance + deposit;
            return Balance;
        }

        public decimal CalaculateInterest(byte mounths)
        {
            Mounths = mounths;

            if (this.Customer.CustomerType=="Individual")
            {
                if (mounths<4)
                {
                    return SpecificRate;
                }
                SpecificRate = Balance * (1 + (InterestRate / 100) * (mounths-3));       
            }

            if (this.Customer.customerType == "Company")
            {
                if (mounths < 3)
                {
                    return SpecificRate;
                }
                SpecificRate = Balance * (1 + (InterestRate / 100) * (mounths - 2));
            }

            return SpecificRate;

        }
    }
}
