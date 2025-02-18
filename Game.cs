using System;
using System.ComponentModel;
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

        public Game(string[] items)
        {
            Console.Write("Enter your name: ");
            player = new Player(Console.ReadLine(), 100);
            currentRoom = new Room();
            random = new Random();
            itemList = items;
        }

        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                itemNum = random.Next(0, itemList.Length);
                item = itemList[itemNum];
                currentRoom = new Room(item);
                Console.WriteLine(currentRoom.GetDescription());
                Console.Write("Would you like to pick up the item yes/no : ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    player.PickUpItem(item);
                    Console.WriteLine($"your inventory contains: {player.InventoryContents()}");
                }
            }
        }
    }
}