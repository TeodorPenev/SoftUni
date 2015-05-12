using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Interfaces;

namespace Infestation.Supplements
{
    class PowerCatalyst:CatalistsBase
    {
        private const int power=3;
        private const int health = 0;
        private const int aggression = 0;

        public PowerCatalyst(string name):base(name,PowerCatalyst.power,PowerCatalyst.health,PowerCatalyst.aggression)
        {
            
        }

    }
}
