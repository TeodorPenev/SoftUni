using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.Supplements
{
    class WeaponrySkill:CatalistsBase
    {
        private const int power = 10;
        private const int health = 0;
        private const int aggression = 3;
        public WeaponrySkill()
            : base(WeaponrySkill.power, WeaponrySkill.health, WeaponrySkill.aggression)
        {
        }
    }
}
