namespace DungeonExplorer
{
    ///<summary>
    ///This class contains an item that the player can interact with
    ///</summary>
    public class Room
    {
        private string _description;
        private string _item;

        ///<summary>
        ///This is a get and set method for the _description attribute
        ///</summary>
        public string Description
        { 
            get { return _description; } 
            set 
            { 
                _description = string.IsNullOrEmpty(value) ? "No Descrition" : value; 
            }
        }

        ///<summary>
        ///This is a get and set method for the _item attribute
        ///</summary>
        public string Item
        {
            get { return _item; }
            set
            {
                _item = string.IsNullOrEmpty(value) ? "No Item" : value;
            }
        }

        ///<summary>
        ///This is a constructor method for when there is an item
        ///</summary>
        public Room(string item)
        {
            Item = item;
            Description = $"This room contains a {Item}";
        }

        ///<summary>
        ///This is a constructor method for when there is no item
        ///</summary>
        public Room()
        {
            Item = "";
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