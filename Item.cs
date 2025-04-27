using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Item
    {
        private int _healthAffect;
        public string _name;

        public int HealthAffect
        {
            get { return _healthAffect; }
            set
            {
                _healthAffect = value;
            }
        }

        public string Name
        {
            get { return _name; }
        }

        public Item(int healthAffect, string name)
        {
            _healthAffect = healthAffect;
            _name = name;
        }

        public virtual void Use(Creature creature)
        {
            Console.WriteLine($"Using item: {_name}");
        }
    }
}
