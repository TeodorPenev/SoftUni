using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.CompanyHierarchy.Interfaces;

namespace _04.CompanyHierarchy.Models
{
    class Customer:Person,ICustomer
    {
        private decimal netPurchase;

        public Customer(string id, string firstName, string lastName, decimal netPurchase) : base(id, firstName, lastName)
        {
            this.netPurchase = netPurchase;
        }

        public decimal NetPurchase
        {
            get { return this.netPurchase; }
            set
            {
                if (value<0m)
                {
                    throw new ArgumentOutOfRangeException("The purchase cannot be negative");
                }
                this.netPurchase = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendFormat("Purchases ammount: {0}\n", this.NetPurchase);

            return result.ToString();
        }
    }
}
