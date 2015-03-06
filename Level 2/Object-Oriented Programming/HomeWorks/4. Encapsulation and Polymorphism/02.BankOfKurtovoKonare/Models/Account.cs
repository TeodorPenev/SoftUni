
using System;
using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare
{
    class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private decimal specificRate;
        private byte mounths;

        public Account(Customer customer,decimal balance,decimal interestRate)
        {
            this.customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Balance value cannot be negative!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate value cannot be nagative!");
                }
                interestRate = value;
            }
        }

        public decimal SpecificRate {
            get { return this.specificRate; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("No interest!");
                }
                this.specificRate = value-this.balance;
            }
        }

        public byte Mounths
        {
            get { return this.mounths;}
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Mounths cannot be negative!");
                }
                this.mounths = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("Customer : {0}, Balance: {1:C}$, Interest Rate: {2}%, Calculated interest for {3}-mounths: {4:C}$", this.customer, this.balance,
                this.interestRate,this.mounths,this.specificRate);
            return result;
        }
    }
}
