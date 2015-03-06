using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    class MortageAccount:Account,IDepositing,IInterestCalculable
    {
        public MortageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public decimal Depositing(decimal deposit)
        {
            Balance = Balance+deposit;
            return Balance;
        }

        public decimal CalaculateInterest(byte mounths)
        {
            Mounths = mounths;

            if (this.Customer.customerType == "Company")
            {
                if (mounths > 12)
                {
                    SpecificRate = (Balance * (1 + ((InterestRate / 100)/2) * 12));
                    SpecificRate += (Balance*(1 + (InterestRate/100)*(mounths-12)));
                    return SpecificRate;
                }
                else
                {
                    SpecificRate = (Balance * (1 + (InterestRate / 100)/2) * mounths);
                    return SpecificRate; 
                }
            }
            if (this.Customer.customerType == "Individual")
            {
                if (mounths<7)
                {
                    return SpecificRate;
                }
                else
                {
                    SpecificRate = (Balance*(1 + (InterestRate/100)*(mounths - 6)));
                    return SpecificRate;
                }
            }
            return SpecificRate;
        }
    }
}
