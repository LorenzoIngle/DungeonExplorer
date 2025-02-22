using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private Random random;
        private string[] itemList;
        private int itemNum;
        private string item;
        private string action;

        public Game()
        {
            // Initialize the game with one room and one player

        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = false;
            while (playing)
            {
                itemNum = random.Next(0, itemList.Length);
                item = itemList[itemNum];
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
                    action = Console.ReadLine();
                    if (action.ToLower() == "view room description")
                    {
                        Console.WriteLine(currentRoom.GetDescription());
                    }
                    else if (action.ToLower() == "view current status")
                    {
                        player.CurrentStatus();
                    }
                    else if (action.ToLower() == "pick up item")
                    {
                        player.PickUpItem(item);
                    }
                    else if (action.ToLower() == "go to next room")
                    {
                        Console.WriteLine("Moving to next room");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine($"'{action}' is not a valid action please try again");
                    }
                }
            }
        }
    }
}