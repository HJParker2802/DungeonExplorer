using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        private string _name;
        private int _health;



        public string Name
        {
            get { return _name; }
            set { Name = _name; }
        }
        public int Health
        {
            get { return _health; }
            set { Health = _health; }
        }
    
        private List<string> inventory = new List<string> { };
        


        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }
        public void PickUpItem(string item)
        {
            inventory.Add(item);
        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
    }
}