using TheSlum.Interfaces;

namespace TheSlum
{
    class Warrior:Character,IAttack
    {
        public Warrior(string id, int x, int y, Team team, int range = 2, int attackPoints = 150, int healthPoints = 200, int defensePoints = 100) : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(System.Collections.Generic.IEnumerable<Character> targetsList)
        {
            foreach (var character in targetsList)
            {
                if (character.IsAlive && this.Team!=character.Team  )
                {
                    return character;
                }
            }
            return null;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.HealthPoints -= item.HealthEffect;
            if (this.HealthPoints<1)
            {
                this.HealthPoints = 1;
            }
            this.DefensePoints -= item.DefenseEffect;
            if (this.DefensePoints<1)
            {
                this.DefensePoints = 1;
            }
            this.AttackPoints -= item.AttackEffect;
            if (this.AttackPoints<1)
            {
                this.AttackPoints = 1;
            }
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
            return base.ToString() + "Attack:"+this.AttackPoints;
        }
    }
}
