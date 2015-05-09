using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Furniture:IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            Model = model;
            Material = material.ToString();
            Price = price;
            Height = height;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length<3)
                {
                    throw new ArgumentNullException("Model cannot be empty, null or with less than 3 symbols.");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get {return this.material; }
            set { this.material = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if ((value==0) || value<0)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00.");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            set
            {
                if ((value == 0) || value < 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00 m.");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name,
                this.Model, this.Material, this.Price, this.Height);
        }
    }
}
