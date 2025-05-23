﻿using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    ///<summary>
    ///This class keeps track of the players name, health, and 
    ///inventory
    ///</summary>
    public class Player : Creature, IDamageable
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
                Item.Collect();
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
            Console.WriteLine("You have the following weapons:");
            inventory.GetWeapons();
            Console.Write("Which weapon would you like to use? ");
            bool UseWeapon = false;
            while (true)
            {
                string weapon = Console.ReadLine();
                for (int i = 0; i < inventory.Count(); i++)
                {
                    if (inventory._inventory[i].Name.Equals(weapon, StringComparison.OrdinalIgnoreCase))
                    {
                        inventory._inventory[i].Use(monster);
                        UseWeapon = true;
                        break;
                    }
                }
                if (UseWeapon)
                {
                    break;
                }
                Console.Write("you dont have that weapon try again ");
            }
        }

        public void Heal()
        {
            Console.WriteLine("You have the following potions:");
            int NoOfPotions = inventory.GetPotions();
            if (NoOfPotions == 0)
            {
                return;
            }
            bool UsePotion = false;
            while (true)
            {
                string potion = Console.ReadLine();
                for (int i = 0; i < inventory.Count(); i++)
                {
                    if (inventory._inventory[i].Name.Equals(potion, StringComparison.OrdinalIgnoreCase))
                    {
                        if (potion.Equals("Large Health Potion", StringComparison.OrdinalIgnoreCase))
                        {
                            Health += 40;
                        }
                        else if (potion.Equals("Small Health Potion", StringComparison.OrdinalIgnoreCase))
                        {
                            Health += 20;
                        }
                        inventory._inventory.RemoveAt(i);
                        UsePotion = true;
                        break;
                    }
                }
                if (UsePotion)
                {
                    break;
                }
                Console.Write("you dont have that potion try again ");
            }
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"You have taken {damage} damage");
        }
    }
}