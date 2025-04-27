using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public abstract class Creature
    {
        private string _name;
        private int _health;

        ///<summary>
        ///This is a get and set method for the _name attribute
        ///</summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = string.IsNullOrEmpty(value) ? "noName" : value;
            }
        }

        ///<summary>
        ///This is a get and set method for the _health 
        ///attribute
        ///</summary>
        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
                /*_health = value;
                Testing.TestHealth(_health);*/
            }
        }

        public Creature(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void Attack(Creature target);
    }
}
