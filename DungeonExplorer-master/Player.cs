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
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name has been set to Greg House due to lack of answer");
                    _name = "Greg House";
                }

                else
                {
                    _name = value;
                }
            }
        }
        public int Health
        {
            get { return _health; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    Console.WriteLine("Health has been set to 100 due to lack of answer");
                    _health = 100;
                }
                else if (value <= 0)
                {
                    Console.WriteLine("Health has been set to 100 due to answer being less than or equal to 0");
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
            }
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