using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class GameMap
    {
        public Room[] rooms;
        public Random random;
        public Item[] itemList = { new Weapon(30, "Sword"), new Weapon(20, "Bow"), new Potion(20, "Small Health Potion"), new Potion(40, "Large Health Potion") };
        public Creature[] monsterList = { null, new Monster ("Lvl 1 Goblin", 20, 5), new Monster("Lvl 2 Goblin", 25, 5), new Monster("Lvl 1 Orc", 40, 10), new Monster("Lvl 2 Orc", 50, 10), new Monster("Troll", 80, 20), new Monster("Dragon", 120, 30) };
        public int itemNum;
        public int itemNum2;
        public int buffer = 0;

        public GameMap()
        {
            rooms = new Room[7];
            random = new Random();
            for (int i = 0; i < rooms.Length; i++)
            {
                itemNum = random.Next(0, itemList.Length);//generates item1
                buffer = 5 * 5;
                itemNum2 = random.Next(0, itemList.Length);//generates item2
                buffer = 5 * 5;
                rooms[i] = new Room(itemList[itemNum], itemList[itemNum2], monsterList[i]);
            }
        }
    }
}
