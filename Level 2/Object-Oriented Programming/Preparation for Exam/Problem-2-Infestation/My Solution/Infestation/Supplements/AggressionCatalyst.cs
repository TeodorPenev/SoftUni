using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.Supplements
{
    class AggressionCatalyst:CatalistsBase
    {
        private const int power = 0;
        private const int health = 0;
        private const int aggression = 3;

        public AggressionCatalyst()
            : base(AggressionCatalyst.power, AggressionCatalyst.health, AggressionCatalyst.aggression)
        {
            
        }
    }
}
