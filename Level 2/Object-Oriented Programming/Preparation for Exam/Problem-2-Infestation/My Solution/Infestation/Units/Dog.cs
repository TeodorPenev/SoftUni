﻿using Infestation.Engine;

namespace Infestation.Units
{
    public class Dog : Unit
    {
        const int DogPower = 5;
        const int DogAggression = 2;
        const int DogHealth = 4;

        public Dog(string id) :
            base(id, UnitClassification.Biological, Dog.DogHealth, Dog.DogPower, Dog.DogAggression)
        {
        }
    }
}