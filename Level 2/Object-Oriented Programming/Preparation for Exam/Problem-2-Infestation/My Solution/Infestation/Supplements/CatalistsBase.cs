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

        public CatalistsBase(string id, int powerEffect=0, int healthEffect=0, int aggressionEffect=0)
        {
            this.Id = id;
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionEffect;
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            throw new NotImplementedException();
        }

        public string Id { get; set; }
        public int PowerEffect { get; set; }

        public int HealthEffect { get; set; }

        public int AggressionEffect { get; set; }

    }
}
