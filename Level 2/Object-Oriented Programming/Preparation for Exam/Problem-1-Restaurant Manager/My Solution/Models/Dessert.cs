using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Dessert:Meal,IDessert
    {
        private bool withShugar;
        private bool isVegan;
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
        }

        public bool WithSugar { get; set; }
        

        public void ToggleSugar()
        {
            this.withShugar = !this.withShugar;
        }
    }
}
