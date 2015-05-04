using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair:Furniture,IConvertibleChair
    {
        private bool isConverted;
        private decimal initialValue ;

        public ConvertibleChair(string model, MaterialType material, decimal price, decimal height,int numberOfLegs) : base(model, material, price, height)
        {
            this.initialValue = height;
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; private set; }

        public bool IsConverted
        {
            get { return isConverted; }
            set { isConverted = false; }
        }

        public void Convert()
        {
            isConverted = !isConverted;
            if (IsConverted == true)
            {
                base.Height = 0.10m;
            }
            else
            {
                base.Height = initialValue;
            }
        }
    }
}
