namespace DungeonExplorer
{
    public class Room
    {
        private string _description;
        private string _item;

        public string Description
        { 
            get { return _description; } 
            set 
            { 
                _description = string.IsNullOrEmpty(value) ? "No Descrition" : value; 
            }
        }

        public string Item
        {
            get { return _item; }
            set
            {
                _item = string.IsNullOrEmpty(value) ? "No Item" : value;
            }
        }

        public Room(string item)
        {
            Item = item;
            Description = $"This room contains a {Item}";
        }

        public Room()
        {
            Item = "";
            Description = "";
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}