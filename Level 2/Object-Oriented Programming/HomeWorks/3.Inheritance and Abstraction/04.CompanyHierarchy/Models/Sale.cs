using System;
using _04.CompanyHierarchy.Interfaces;

namespace _04.CompanyHierarchy.Models
{
    public class Sale : ISale
    {
        private string productName;

        private DateTime saleDate ;

        private decimal price;

        public Sale(string productName, DateTime saleDate, decimal price)
        {
            this.ProductName = productName;
            this.SaleDate = saleDate;
            this.Price = price;
        }


       public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.productName = value;
            }
        }

       public DateTime SaleDate { get; set; }
   
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("price", "Product proce cannot be negative.");
                }

                this.price = value;
            }
        }
    }
}

