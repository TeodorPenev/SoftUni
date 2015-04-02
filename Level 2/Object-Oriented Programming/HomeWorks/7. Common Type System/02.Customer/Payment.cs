using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Customer
{
    class Payment
    {
        private string productName;
        private decimal price;
        
        public Payment(string productName,decimal price)
        {
            this.productName = productName;
            this.price = price;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Product name: {0}, Price: {1}", this.productName, this.price));
            return result.ToString();
        }
    }
}