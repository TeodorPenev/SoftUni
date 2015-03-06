using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum
{
    class Mage:Character
    {
        public Mage(string id, int x, int y, Team team, int range = 5, int attackPoint = 300, int defensePoints = 50, int healthPoints = 150) : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoint = attackPoint;
        }

        public int AttackPoint { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            throw new NotImplementedException();
        }

        public override void AddToInventory(Item item)
        {
            throw new NotImplementedException();
        }

        public override void RemoveFromInventory(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
