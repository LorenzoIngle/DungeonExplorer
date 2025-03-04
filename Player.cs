using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        private string _name;
        private int _health;
        private List<string> inventory = new List<string>();

        public string Name
        { 
            get { return _name; } 
            set 
            {
                _name = string.IsNullOrEmpty(value) ? "noName" : value;
            }
        }

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

        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }

        public void PickUpItem(string item)
        {
            if (inventory.Count < 1)
            {
                inventory.Add(item);
            }
            else
            {
                Console.WriteLine("Inventory full, could not pick up item");
            }
        }

        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }

        public void CurrentStatus()
        {
            Console.WriteLine($"{Health} HP, your inventory contains: {InventoryContents()}");
        }
    }
}