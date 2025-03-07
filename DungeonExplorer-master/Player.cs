using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        private string _name;
        private int _health;



        public string Name { get; set; }
        public int Health { get; set; }

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