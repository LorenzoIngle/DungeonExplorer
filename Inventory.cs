using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Inventory
    {
        public List<Item> _inventory;

        public Inventory()
        {
            _inventory = new List<Item>();
        }

        public int Count()
        {
            return _inventory.Count;
        }

        public void Add(Item item)
        {
            _inventory.Add(item);
        }

        public string InventoryContents()
        {
            string invList = "";
            foreach (Item item in _inventory)
            {
                invList = invList + ", a " + item.Name;
            }
            return invList;
        }

        public void GetWeapons()
        {
            List<Item> weapons =
            (from item in _inventory
            where item is Weapon
            select item).ToList();
            foreach (Item item in weapons)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        public int GetPotions()
        {
            List<Item> potions =
                (from item in _inventory
                 where item is Potion
                 select item).ToList();
            if (potions.Count() == 0)
            {
                Console.WriteLine("You have no potions");
                return potions.Count();
            }
            else
            {
                foreach (Item item in potions)
                {
                    Console.WriteLine($"{item.Name}");
                }
                Console.Write("Which potion would you like to use? ");
            }
            return potions.Count();
        }
    }
}
