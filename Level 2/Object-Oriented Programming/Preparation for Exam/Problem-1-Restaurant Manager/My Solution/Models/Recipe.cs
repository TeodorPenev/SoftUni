using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    abstract class Recipe:IRecipe
    {
        private string name;
        private decimal price;
        protected int calories;
        private int quantityPerServing;
        protected int timeToPrepare;
        protected bool isVegan;
        protected bool withShugar;

        protected Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set {
                if (value<=0)
                {
                    throw new ArgumentException("The price must be positive.");
                }
                this.price = value;
            }
        }

        public virtual int Calories
        {
            get { return this.calories; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The calories must be positive.");
                }
                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The quantity per serving must be positive.");
                }
                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; set; }

        public virtual int TimeToPrepare
        {
            get { return this.timeToPrepare; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The time to repare must be positive.");
                }
                this.timeToPrepare = value;
            }
        }

        public bool IsVegan
        {
            get { return this.isVegan; }
            set { this.isVegan = value; }
        }

        public bool IsCarbonated { get; set; }

        public bool ContainsPasta { get; set; }

        public string Type { get; set; }

        public bool WithSugar
        {
            get { return this.withShugar; }
            set { this.withShugar = value; }
        }
    }
}
