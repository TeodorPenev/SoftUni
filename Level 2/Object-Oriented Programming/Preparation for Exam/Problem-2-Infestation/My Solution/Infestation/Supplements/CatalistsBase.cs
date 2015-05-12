using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Infestation.Interfaces;
using Infestation.Units;
using Infestation.Engine;

namespace Infestation.Supplements
{
    class CatalistsBase:ISupplement
    {

        public CatalistsBase(int powerEffect, int healthEffect, int aggressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionEffect;
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            throw new NotImplementedException();
        }

        public int PowerEffect { get; set; }

        public int HealthEffect { get; set; }

        public int AggressionEffect { get; set; }

    }
}
