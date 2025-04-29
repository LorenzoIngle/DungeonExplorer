using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Monster : Creature, IDamageable
    {
        private int damage;

        public int Damage
        {
            get { return damage; }
            set
            {
                damage = value;
            }
        }

        public Monster(string name, int health, int damage) : base(name, health)
        {
            this.damage = damage;
        }

        public override void Attack(Creature player)
        {
            player.Health -= damage;
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"You have taken {damage} damage");
        }
    }
}
