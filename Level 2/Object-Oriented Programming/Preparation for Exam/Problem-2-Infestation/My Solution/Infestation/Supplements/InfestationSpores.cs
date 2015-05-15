using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Interfaces;

namespace Infestation.Supplements
{
    class InfestationSpores:CatalistsBase
    {
        private const int power = -1;
        private const int health = 0;
        private const int aggression = 20;

        public InfestationSpores()
            : base(InfestationSpores.power, InfestationSpores.health, InfestationSpores.aggression)
        {
        }
    }
}
