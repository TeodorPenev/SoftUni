using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public string Name
        {
            get
            {
              return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Component Name cannot be empty"); 
                }
                this.name = value;
            }

        }

        public string Details
    {
            get
            {
                return details;
            }
            set
            {
                this.details = value;
            }
    }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price)
            :this(name,null,price)
        {
            
        }

        public override string ToString()
        {
            string result = String.Format("Component: (Name: {0}", this.name);
            if (this.details != null)
            {
                result += String.Format(", Details: {0}",this.details);
            }

            result += String.Format(", Price: {0:F2} lv.)", this.price);

            return result;
        }
    }

}
