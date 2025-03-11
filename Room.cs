namespace DungeonExplorer
{
    ///<summary>
    ///This class contains an item that the player can interact with
    ///</summary>
    public class Room
    {
        private string _description;
        private string _item1;
        private string _item2;

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
        ///This is a get and set method for the _item1 attribute
        ///</summary>
        public string Item1
        {
            get { return _item1; }
            set
            {
                _item1 = string.IsNullOrEmpty(value) ? "No Item" : value;
            }
        }

        ///<summary>
        ///This is a get and set method for the _item2 attribute
        ///</summary>
        public string Item2
        {
            get { return _item2; }
            set
            {
                _item2 = string.IsNullOrEmpty(value) ? "No Item" : value;
            }
        }

        ///<summary>
        ///This is a constructor method for when there is items
        ///</summary>
        public Room(string item1, string item2)
        {
            Item1 = item1;
            Item2 = item2;
            Description = $"This room contains a {Item1} and a {Item2}";
        }

        ///<summary>
        ///This is a constructor method for when there is no item
        ///</summary>
        public Room()
        {
            Item1 = "";
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