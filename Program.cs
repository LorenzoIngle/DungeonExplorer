﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DungeonExplorer
{
    ///<summary>
    ///This class defines the items within the game and creates 
    ///a new instance of the game class
    ///</summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Health potion", "Sword", "Bow", 
                "Bone" };
            Game game = new Game(items);
            game.Start();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
