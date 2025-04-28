using System;
using System.ComponentModel;
using System.Media;

namespace DungeonExplorer
{
    ///<summary>
    ///This class contains an instance of the Player class, Room
    ///class and Random class it also controls the game loop 
    ///</summary>
    internal class Game
    {
        private Player player;
        private GameMap map;
        private Room currentRoom;
        private Random random;
        private string[] itemList;
        private string action;
        private int roomNum;

        ///<summary>
        ///This is a get and set method for the action attribute
        ///</summary>
        public string Action
        {
            get { return action; }
            set
            {
                action = value;
            }
        }

        ///<summary>
        ///This is a constructor method
        ///</summary>
        public Game(string[] Items)
        {
            Console.Write("Enter your name: ");
            player = new Player(Console.ReadLine(), 100);
            map = new GameMap();
            random = new Random();
            itemList = Items;
            roomNum = 0;
        }

        ///<summary>
        ///This method runs the game loop allowing the user to 
        ///decide an action to take and ends the game after 10 
        ///rooms
        ///</summary>
        public void Start()
        {
            bool playing = true;
            while (playing)
            {
                currentRoom = map.rooms[roomNum];
                Console.WriteLine("-------------------" +
                        "---------------------------------" +
                        "---------------------");
                Console.WriteLine(currentRoom.GetDescription());
                while (true)
                {
                    Console.WriteLine("-------------------" +
                        "---------------------------------" +
                        "---------------------");
                    Console.WriteLine();
                    if (currentRoom.Monster == null)
                    {
                        Console.WriteLine("View current status");
                        Console.WriteLine();
                        Console.WriteLine("Pick up item");
                        Console.WriteLine();
                        Console.WriteLine("Heal");
                        Console.WriteLine();
                        Console.WriteLine("Go to next room");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("View current status");
                        Console.WriteLine();
                        Console.WriteLine("Pick up item");
                        Console.WriteLine();
                        Console.WriteLine("Attack monster");
                        Console.WriteLine();
                        Console.WriteLine("Heal");
                        Console.WriteLine();
                    }
                    Console.Write("Which action would you like" +
                        " to perform: ");

                    Action = Console.ReadLine();
                    if (Action.ToLower() == "view current " +
                        "status")
                    {
                        player.CurrentStatus();
                    }
                    else if (Action.ToLower() == "pick up item")
                    {
                        if (currentRoom.Item1 == null && currentRoom.Item2 == null)
                        {
                            Console.WriteLine("no items to pick up");
                        }
                        else if (currentRoom.Item1 == null)
                        {
                            Console.WriteLine("picking up " +
                                $"{currentRoom.Item2.Name}");
                            player.PickUpItem(currentRoom.Item2);
                            currentRoom.Item2 = null;
                        }
                        else if (currentRoom.Item2 == null)
                        {
                            Console.WriteLine("picking up " +
                                $"{currentRoom.Item1.Name}");
                            player.PickUpItem(currentRoom.Item1);
                            currentRoom.Item1 = null;
                        }
                        else
                        {

                            Console.Write($"which item would you " +
                                $"like to pick up " +
                                $"({currentRoom.Item1.Name} or " +
                                $"{currentRoom.Item2.Name})? : ");

                            string itemToPickUp = Console.ReadLine();

                            if (itemToPickUp.Equals(
                                currentRoom.Item1.Name,
                                StringComparison.OrdinalIgnoreCase))
                            {
                                player.PickUpItem(currentRoom.Item1);
                                currentRoom.Item1 = null;
                            }
                            else if (itemToPickUp.Equals(
                                currentRoom.Item2.Name,
                                StringComparison.OrdinalIgnoreCase))
                            {
                                player.PickUpItem(currentRoom.Item2);
                                currentRoom.Item2 = null;
                            }
                            else
                            {
                                Console.WriteLine("that is not a " +
                                    "item in the room.");
                            }
                        }
                    }
                    else if (Action.ToLower() == "attack monster")
                    {
                        if (currentRoom.Monster == null)
                        {
                            Console.WriteLine("There is no monster " +
                                "to attack");
                        }
                        else
                        {
                            player.Attack(currentRoom.Monster);
                            if (currentRoom.Monster.Health <= 0)
                            {
                                Console.WriteLine($"You killed the " +
                                    $"{currentRoom.Monster.Name}");
                                currentRoom.Monster = null;
                            }
                            else
                            {
                                Console.WriteLine($"the {currentRoom.Monster.Name} " +
                                    $"has {currentRoom.Monster.Health} HP left");
                                Console.WriteLine($"{currentRoom.Monster.Name} " +
                                    $"attacked you");
                                currentRoom.Monster.Attack(player);
                                if (player.Health <= 0)
                                {
                                    Console.WriteLine("You died");
                                    playing = false;
                                    break;
                                }
                                player.CurrentStatus();
                            }
                        }
                    }
                    else if (Action.ToLower() == "heal")
                    {
                        if (player.Health == 100)
                        {
                            Console.WriteLine("You are already at full health");
                            continue;
                        }
                        player.Heal();
                        if (currentRoom.Monster != null)
                        {
                            Console.WriteLine("The monster attacked you " +
                                "while you were healing");
                            currentRoom.Monster.Attack(player);
                            if (player.Health <= 0)
                            {
                                Console.WriteLine("You died");
                                playing = false;
                                dead = true;
                                break;
                            }
                            player.CurrentStatus();
                        }
                        else
                        {
                            Console.WriteLine("You healed yourself");
                            player.CurrentStatus();
                        }
                    }
                    else if (Action.ToLower() == "go to next " +
                        "room")
                    {
                        if (currentRoom.Monster != null)
                        {
                            Console.WriteLine("You cannot leave " +
                                "the room while there is a monster");
                            currentRoom.Monster.Attack(player);
                            if (player.Health <= 0)
                            {
                                Console.WriteLine("You died");
                                playing = false;
                                dead = true;
                                break;
                            }
                            player.CurrentStatus();
                        }
                        else
                        {
                            Console.WriteLine("Moving to next " +
                                "room");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"'{Action}' is " +
                            $"not a valid action please try " +
                            $"again");
                    }
                }
                roomNum += 1;
                if (dead == true)
                {
                    Console.WriteLine("Game over");
                    break;
                }
                if (roomNum == 7)
                {
                    Console.WriteLine("you beat the game," +
                        " you survived 7 rooms");
                    player.CurrentStatus();
                    break;
                }
            }
        }
    }
}
