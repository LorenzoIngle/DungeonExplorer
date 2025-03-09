using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    ///<summary>
    ///This class keeps track of the players name, health, and inventory
    ///</summary>
    public class Player
    {
        private string _name;
        private int _health;
        private List<string> inventory = new List<string>();

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
        ///This is a get and set method for the _health attribute
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

        ///<summary>
        ///This is a constructor method
        ///</summary>
        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }

        ///<summary>
        ///This method adds an item to the inventory if it is empty and returns an error message if it is full
        ///</summary>
        public void PickUpItem(string Item)
        {
            if (inventory.Count < 1)
            {
                inventory.Add(Item);
            }
            else
            {
                Console.WriteLine("Inventory full, could not pick up item");
            }
        }

        ///<summary>
        ///this method outputs the contents of the inventory
        ///</summary>
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }

        ///<summary>
        ///This method prints the health and inventory of the player
        ///</summary>
        public void CurrentStatus()
        {
            Console.WriteLine($"{Health} HP, your inventory contains: {InventoryContents()}");
        }
    }
}