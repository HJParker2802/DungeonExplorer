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
                if (string.IsNullOrWhiteSpace(value))//checks if the user did not put a name
                {
                    Console.WriteLine("Name has been set to Greg House due to lack of answer");
                    _name = "Greg House";//if user didnt put a name, they are being given this random name
                }

                else
                {
                    _name = value;//if user put name, they can keep it
                }
            }
        }
        public int Health
        {
            get { return _health; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))//checking if the user put an answer, if not, default to 100
                {
                    Console.WriteLine("Health has been set to 100 due to lack of answer");
                    _health = 100;
                }
                else if (value <= 0)//checking if user put an answer less than or equal to 0, if so, health will default at 100 to give a chance at the game
                {
                    Console.WriteLine("Health has been set to 100 due to answer being less than or equal to 0");
                    _health = 100;
                }
                else
                {
                    _health = value;//if user put appropriate health, they can have it
                }
            }
        }

        private List<string> inventory = new List<string> { };
        


        public Player(string name, int health) //sets name and health with getters and setters
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