﻿using System;
using System.ComponentModel;
using System.Media;

namespace DungeonExplorer
{
    ///<summary>
    ///This class contains an instance of the Player class, Room class and Random class it also controls the game loop 
    ///</summary>
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private Random random;
        private string[] itemList;
        private int itemNum;
        private string item;
        private string action;
        private int roomNum;

        ///<summary>
        ///This is a get and set method for the action attribute
        ///</summary>
        public string Action
        {
            get { return action;  }
            set
            {
                action = value
            }
        }

        ///<summary>
        ///This is a constructor method
        ///</summary>
        public Game(string[] Items)
        {
            Console.Write("Enter your name: ");
            player = new Player(Console.ReadLine(), 100);
            currentRoom = new Room();
            random = new Random();
            itemList = Items;
            roomNum = 0;
        }

        ///<summary>
        ///This method runs the game loop allowing the user to decide an action to take and ends the game after 10 rooms
        ///</summary>
        public void Start()
        {
            bool playing = true;
            while (playing)
            {
                itemNum = random.Next(0, itemList.Length); 
                item = itemList[itemNum]; //this line and the one above determine which item will be in the next room
                currentRoom = new Room(item);
                while (true)
                {
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("View room description");
                    Console.WriteLine();
                    Console.WriteLine("View current status");
                    Console.WriteLine();
                    Console.WriteLine("Pick up item");
                    Console.WriteLine();
                    Console.WriteLine("Go to next room");
                    Console.WriteLine();
                    Console.Write("Which action would you like to perform: ");
                    Action = Console.ReadLine();
                    if (Action.ToLower() == "view room description")
                    {
                        Console.WriteLine(currentRoom.GetDescription());
                    }
                    else if (Action.ToLower() == "view current status")
                    {
                        player.CurrentStatus();
                    }
                    else if (Action.ToLower() == "pick up item")
                    {
                        player.PickUpItem(item);
                    }
                    else if (Action.ToLower() == "go to next room")
                    {
                        Console.WriteLine("Moving to next room");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine($"'{Action}' is not a valid action please try again");
                    }
                }
                roomNum += 1;
                if (roomNum == 10)
                {
                    Console.WriteLine("you beat the game, you survived 10 rooms");
                    player.CurrentStatus();
                    break;
                }
            }
        }
    }
}