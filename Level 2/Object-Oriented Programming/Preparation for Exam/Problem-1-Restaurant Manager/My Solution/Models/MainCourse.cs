﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    internal class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare,
            bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            base.IsVegan = isVegan;
            this.Type = type;
        }
    }
}

