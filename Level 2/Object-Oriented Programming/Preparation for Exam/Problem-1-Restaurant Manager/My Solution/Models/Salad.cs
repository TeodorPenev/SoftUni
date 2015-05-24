using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Salad:Meal,ISalad
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare,
            bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            base.ContainsPasta = containsPasta;
            IsVegan = true;
        }

    }
}
