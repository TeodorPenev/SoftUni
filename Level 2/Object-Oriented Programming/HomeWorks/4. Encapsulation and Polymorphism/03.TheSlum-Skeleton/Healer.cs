using TheSlum.Interfaces;

namespace TheSlum
{
    class Healer:Character,IHeal
    {
        public Healer(string id, int x, int y, Team team,int healingPoints=60, int range = 6, int defensePoints = 50, int healthPoints = 75) : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }



        public override Character GetTarget(System.Collections.Generic.IEnumerable<Character> targetsList)
        {
            foreach (var character in targetsList)
            {
                if (character.IsAlive && character.Team==this.Team)
                {
                    return character;
                }
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
    }
}
