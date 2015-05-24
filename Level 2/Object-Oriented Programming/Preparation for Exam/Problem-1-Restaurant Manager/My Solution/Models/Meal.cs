using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Meal:Recipe,IMeal
    {
        private bool isVegan;
        private MetricUnit metricUnit;

        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            base.Unit = MetricUnit.Grams;
            IsVegan = true;
        }

        public bool IsVegan
        {
            get { return this.isVegan; }
            set { this.isVegan = value; }
        }

        public void ToggleVegan()
        {
             isVegan = !isVegan;
        }
    }
}
