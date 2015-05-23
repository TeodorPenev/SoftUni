using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    internal class Drink : Recipe, IDrink
    {
        private bool isCarbonated;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare,
            bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            base.Unit = MetricUnit.Milliliters;
        }

        public bool IsCarbonated { get; set; }

        public override int Calories
        {
            get { return base.calories; }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentException("The calories in a drink must not be greater than 100.");
                }
                base.calories = value;
            }
        }

        public override int TimeToPrepare
        {
            get { return base.timeToPrepare; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The time to repare must be positive.");
                }
                base.timeToPrepare = value;
            }
        }
    }
}
