using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("You have the following weapons:");
            foreach (Item item in _inventory)
            {
                if (item is Weapon)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }
            Console.Write("Which weapon would you like to use? ");
        }

        public int GetPotions()
        {
            int NoOfPotions = 0;
            Console.WriteLine("You have the following potions:");
            foreach (Item item in _inventory)
            {
                if (item is Potion)
                {
                    Console.WriteLine($"{item.Name}");
                    NoOfPotions++;
                }
            }
            if (NoOfPotions == 0)
            {
                Console.WriteLine("You have no potions");
                return NoOfPotions;
            }
            Console.Write("Which potion would you like to use? ");
            return NoOfPotions;
        }
    }
}
