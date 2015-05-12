using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.Supplements
{
    class HealthCatalyst:CatalistsBase
    {
        private const int power = 0;
        private const int health = 3;
        private const int aggression = 0;

        public HealthCatalyst()
            : base(HealthCatalyst.power, HealthCatalyst.health, HealthCatalyst.aggression)
        {
            
        }
    }

}
