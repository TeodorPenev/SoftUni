using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Engine;

namespace Infestation.Units
{
    class Queen:Unit
    {
        private const UnitClassification unitType = UnitClassification.Psionic;
        private const int queenHealth = 30;
        private const int queenPower = 1;
        private const int queenAggression = 1;

        public Queen(string id)
            : base(id, unitType, queenHealth, queenPower, queenAggression)
        {
        }
    }
}
