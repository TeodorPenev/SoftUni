using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Engine;

namespace Infestation.Units
{
    class Parasite:Unit
    {
        private const UnitClassification unitType=UnitClassification.Biological;
        private const int parasiteHealth = 1;
        private const int parasitePower = 1;
        private const int parasiteAggression = 1;


        public Parasite(string id)
            : base(id, unitType, parasiteHealth, parasitePower, parasiteAggression)
        {
        }
    }
}
