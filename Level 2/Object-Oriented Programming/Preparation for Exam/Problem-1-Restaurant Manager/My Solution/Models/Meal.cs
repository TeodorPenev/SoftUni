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
        
        private MetricUnit metricUnit;

        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            base.Unit = MetricUnit.g;
            base.IsVegan = true;
        }
        public void ToggleVegan()
        {
             isVegan = !isVegan;
        }
    }
}
