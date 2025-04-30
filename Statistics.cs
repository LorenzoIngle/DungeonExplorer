using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Statistics
    {
        public int actionsUsed;
        public int damageDealt;

        public Statistics()
        {
            actionsUsed = 0;
            damageDealt = 0;
        }

        public void AddAction()
        {
            actionsUsed++;
        }

        public void AddDamage(int damage)
        {
            damageDealt += damage;
        }

        public void CheckStats()
        {
            Console.WriteLine("Actions Used: " + actionsUsed + " (Not including checking stats)");
            Console.WriteLine("Damage Dealt: " + damageDealt + "HP");
        }
    }
}
