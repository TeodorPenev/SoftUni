using System.Collections.Generic;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Mage:Character,IAttack
    {
        public Mage(string id, int x, int y, Team team, int range = 5, int attackPoint = 300, int defensePoints = 50, int healthPoints = 150) : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints= attackPoint;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            foreach (var character in targetsList)
            {
                if (character.IsAlive && character.Team!=this.Team)
                {
                    return character;
                }
                ;    
            }
            return null;
        }

        public override void AddToInventory(Item item)
        {
            Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            Inventory.Remove(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.Inventory.Remove(item);
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            return base.ToString() + " Attack:" +
            this.AttackPoints;
        }
    }
}
