using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Potion : Item
    {
        public Potion(int healthAffect, string name) : base(healthAffect, name) { }
        public override void Use(Creature player)
        {
            player.Health += HealthAffect;
        }
    }
}
