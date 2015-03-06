using System;
namespace _02.BankOfKurtovoKonare.Models
{
    class Customer
    {
        private string name;
        public string customerType;

        public Customer(string name,string customerType)
        {
            this.name = name;
            this.CustomerType = customerType;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty!");
                }
            }
        }

        public string CustomerType
        {
            get { return this.customerType; }
            set
            {
                if (value != "Individual" && value != "Company")
                {
                    throw new ArgumentException("Custumers can be \"Individual\" or \"Company\"");
                }
                this.customerType = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("Name: {0}, Customer Type: {1}", this.name, this.customerType);
            return result;
        }
    }
}
