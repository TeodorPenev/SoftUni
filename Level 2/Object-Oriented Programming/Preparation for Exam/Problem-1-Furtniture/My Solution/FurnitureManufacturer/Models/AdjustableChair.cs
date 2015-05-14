﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair : Furniture, IAdjustableChair
    {
        public AdjustableChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; private set; }

        public void SetHeight(decimal height)
        {
            base.Height = height;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}", this.NumberOfLegs)
            ;
        }
    }
}