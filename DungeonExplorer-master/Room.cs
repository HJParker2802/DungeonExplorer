namespace DungeonExplorer
{
    public class Room
    {
        private string description;

        public Room(string description)
        {
            this.description = description;//Gives description of the room
        }

        public string GetDescription()
        {
            return description;//returns the description of the room
        }
    }
}