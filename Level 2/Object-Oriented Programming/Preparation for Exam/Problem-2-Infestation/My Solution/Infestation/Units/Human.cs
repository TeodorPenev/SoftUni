﻿using Infestation.Engine;

namespace Infestation.Units
{
    public class Human : Unit
    {
        public const int HumanHealth = 10;
        public const int HumanPower = 4;
        public const int HumanAggression = 1;

        public Human(string id)
            : base(id, UnitClassification.Biological, Human.HumanHealth, Human.HumanPower, Human.HumanAggression)
        {
        }
    }
}
