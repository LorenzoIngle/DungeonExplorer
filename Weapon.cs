using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Weapon : Item
    {
        public Weapon(int healthAffect, string name) : base(healthAffect, name) { }
        public override void Use(Creature monster)
        {
            monster.Health -= HealthAffect;
        }
    }
}
