using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Engine;

namespace Infestation.Units
{
    class Marine:Human
    {
        private int counter;
        public Marine(string id) : base(id)
        {

        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Power <= Marine.HumanAggression)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                var itemMaxHealth = attackableUnits.Max(y => y.Health);
                var itemMax = attackableUnits.Where(x => x.Health == itemMaxHealth);

                optimalAttackableUnit = (UnitInfo)itemMax.First();
            }

            return optimalAttackableUnit;
        }
    }
}
