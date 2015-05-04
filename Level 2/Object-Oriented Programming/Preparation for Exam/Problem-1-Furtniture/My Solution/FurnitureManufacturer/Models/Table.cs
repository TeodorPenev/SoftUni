using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Table:Furniture,ITable
    {
     
        public Table(string model, MaterialType material, decimal price, decimal height,decimal length,decimal width)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }
         
        public decimal Area
        {
            get { return this.Length*this.Width; }
        }
    }
}
