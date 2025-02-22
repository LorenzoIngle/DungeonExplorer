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