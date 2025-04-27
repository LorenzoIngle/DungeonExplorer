namespace DungeonExplorer
{
    ///<summary>
    ///This class contains an item that the player can interact with
    ///</summary>
    public class Room
    {
        private string _description;
        private Item _item1;
        private Item _item2;
        private Creature _monster;

        ///<summary>
        ///This is a get and set method for the _description 
        ///attribute
        ///</summary>
        public string Description
        {
            get { return _description; }
            set
            {
                _description = string.IsNullOrEmpty(value) ? 
                    "No Descrition" : value;
            }
        }

        ///<summary>
        ///This is a get and set method for the _item1 attribute
        ///</summary>
        public Item Item1
        {
            get { return _item1; }
            set { _item1 = value; }
        }

        ///<summary>
        ///This is a get and set method for the _item2 attribute
        ///</summary>
        public Item Item2
        {
            get { return _item2; }
            set { _item2 = value; }
        }

        public Creature Monster
        {
            get { return _monster; }
            set { _monster = value; }
        }

        ///<summary>
        ///This is a constructor method for when there is items
        ///</summary>
        public Room(Item item1, Item item2, Creature monster)
        {
            Item1 = item1;
            Item2 = item2;
            Monster = monster;
            if (monster != null)
            {
                Description = $"This room contains a {Item1.Name} " +
                    $"a {Item2.Name} and a {Monster.Name} " +
                    $"with {Monster.Health} HP ";
            }
            else
            {
                Description = $"This room contains a {Item1.Name} " +
                $"and a {Item2.Name}";
            }
        }

        ///<summary>
        ///This is a constructor method for when there is no 
        ///item
        ///</summary>
        public Room()
        {
            Item1 = null;
            Item2 = null;
            Monster = null;
            Description = "";
        }

        ///<summary>
        ///This method returns a description of the room
        ///</summary>
        public string GetDescription()
        {
            return Description;
        }
    }
}