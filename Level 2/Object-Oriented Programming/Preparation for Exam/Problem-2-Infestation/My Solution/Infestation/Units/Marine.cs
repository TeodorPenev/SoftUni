using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Engine;

namespace Infestation.Units
{
    class Marine:Human
    {
        public Marine(string id) : base(id)
        {

        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            //This method finds the unit with the least power and attacks it
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Power <= Marine.HumanAggression)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }
    }
}
