using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Monster : Creature
    {
        private int damage;

        public Monster(string name, int health, int damage) : base(name, health)
        {
            this.damage = damage;
        }

        public override void Attack(Creature player)
        {
            player.Health -= damage;
        }
    }
}
