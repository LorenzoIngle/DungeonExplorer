using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    ///<summary>
    ///This class keeps track of the players name, health, and 
    ///inventory
    ///</summary>
    public class Player : Creature
    {
        private Inventory inventory = new Inventory();

        ///<summary>
        ///This is a constructor method
        ///</summary>
        public Player(string name, int health) : base(name, health)
        {
            inventory.Add(new Weapon(10, "Fist"));
        }

        ///<summary>
        ///This method adds an item to the inventory if it is 
        ///empty and returns an error message if it is full
        ///</summary>
        public void PickUpItem(Item Item)
        {
            if (inventory.Count() < 5)
            {
                inventory.Add(Item);
            }
            else
            {
                Console.WriteLine("Inventory full, could not " +
                    "pick up item");
            }
        }

        ///<summary>
        ///This method prints the health and inventory of 
        ///the player
        ///</summary>
        public void CurrentStatus()
        {
            Console.WriteLine($"{Health} HP, your inventory " +
                $"contains: {inventory.InventoryContents()}");
        }

        public override void Attack(Creature monster)
        {
            inventory.GetWeapons();
            while (true)
            {
                string weapon = Console.ReadLine();
                for (int i = 0; i < inventory.Count(); i++)
                {
                    if (inventory._inventory[i].Name == weapon)
                    {
                        inventory._inventory[i].Use(monster);
                        break;
                    }
                }
                Console.Write("you dont have that weapon try again");
            }
        }

        public void Heal()
        {
            inventory.GetPotions();
        }
    }
}