using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Engine;

namespace Infestation.Units
{
    class Tank:Unit
    {
        private const UnitClassification unitType = Engine.UnitClassification.Mechanical;
        private const int health = 20;
        private const int power = 25;
        private const int aggression = 25;

        public Tank(string id) : base(id, unitType, health, power, aggression)
        {
        }
    }
}
