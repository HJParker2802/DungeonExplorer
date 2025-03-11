using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player Player1;
        private Room StartRoom; 
        private Room Corridor;
        private Room BossRoom;
        private Room EndRoom;
        public int RoomCounter;


        public Game()
        {
            try
            { 
                Console.WriteLine("The game is starting, you will be asked for some quick details before the game starts");

                // Initialize the game with one room and one player
                Console.WriteLine("Getting user information");
                Console.WriteLine("What is your name?");
                string Temp_Name = Console.ReadLine();
                Console.WriteLine("How much health would you like to start on? Typical health is 100.");
                string strStartHealth = Console.ReadLine();
                int StartHealth;

                bool ConvertChecker = int.TryParse(strStartHealth, out StartHealth);
                if (ConvertChecker == false)
                {
                    StartHealth = 0;
                }

                Player1 = new Player(Temp_Name, StartHealth);
                RoomCounter = 1;
                StartRoom = new Room("You are in a small, dimly lit room with a rusted chest in the corner and a door leading to a corridor");
                Corridor = new Room("You are in a corridor that has dim lighting");
                BossRoom = new Room("You have entered a large room with a huge spider that wants to eat you");
                EndRoom = new Room("You are in a room with a bed, it is time to rest and accept victory!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Start()
        {
            bool Dagger = false;
            int PlayerHealth = Player1.Health;
            
                Player1.Health= PlayerHealth;
                Console.WriteLine($"Hello {Player1.Name}, you will be starting your adventure with {Player1.Health} health. You will start in the first room with an empty inventory. Good Luck getting to the last room. ");
                Console.WriteLine($"Name:{Player1.Name}");
                Console.WriteLine($"Health:{Player1.Health}");
                Console.WriteLine($"Room:{StartRoom.GetDescription()}");

                // Change the playing logic into true and populate the while loop
                bool playing = true;
            while (playing)
            {
                // Code your playing logic here
                //Console.WriteLine($"Inv:{Player1.InventoryContents()}");
                Console.WriteLine();

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] End Game");
                Console.WriteLine("[1] View Name");
                Console.WriteLine("[2] View Health");
                Console.WriteLine("[3] View Room Description");
                Console.WriteLine("[4] View Inventory");
                Console.WriteLine("[5] Interact With Room");
                Console.WriteLine("[6] Next Room");
                string strAnswer = Console.ReadLine();
                int Answer;

                bool ConvertChecker = int.TryParse(strAnswer, out Answer);
                if (ConvertChecker == false)
                {
                    Answer = 0;
                }

                switch(Answer)
                {
                    case 0:
                        playing = false;
                        break;
                    case 1:
                        DisplayName();
                        break;
                    case 2:
                        DisplayHealth();
                        break;
                    case 3:
                        DisplayRoom();
                        break;
                    case 4:
                        DisplayInv();
                        break;
                    case 5:
                        switch(RoomCounter)
                        {
                            case 1:
                                Console.WriteLine("In the chest you have found a Steel Dagger, you place this into your inventory");
                                Player1.PickUpItem("Steel Dagger");
                                Dagger = true;
                                break;
                            case 2:
                                Console.WriteLine("There is nothing in this room to interact with, please move room to interact");
                                break;
                            case 3:
                                Console.WriteLine("There is a huge spider that wants to eat you, what would you like to do?");
                                int SpiderHealth = 50;
                                while (SpiderHealth > 0)
                                {
                                    if (!Dagger)
                                    {
                                        Console.WriteLine("You have nothing to defend yourself! The spider will eat you until you die");
                                        Console.WriteLine("You have been eaten!");
                                        playing = false;
                                        break;
                                    }
                                    else
                                    {

                                        Console.WriteLine("[0] Use weapon to stab its eyes");
                                        Console.WriteLine("[1] Use weapon to stab its mouth");
                                        Console.WriteLine("[2] Do nothing");

                                        string strAttackChoice = Console.ReadLine();
                                        int AttackChoice;

                                        bool AnswerConversoinChecker = int.TryParse(strAttackChoice, out AttackChoice);
                                        if (AnswerConversoinChecker == false)
                                        {
                                            AttackChoice = 2;
                                            Console.WriteLine("You have not input a valid response, you will stand still and take damage");
                                        }
                                        if (AnswerConversoinChecker == true)
                                        {
                                            if (AttackChoice == 0)
                                            {
                                                Console.WriteLine("You have chosen to stab its eyes, Spider takes 25 damage");
                                                SpiderHealth = SpiderHealth - 25;
                                            }
                                            if (AttackChoice == 1)
                                            {
                                                Console.WriteLine("You have chosen to stab its eyes, Spider takes 20 damage");
                                                SpiderHealth = SpiderHealth - 20;

                                            }
                                            if (AttackChoice == 2)
                                            {
                                                Console.WriteLine("You have chosen to do nothing, you will stand still and take damage");

                                                PlayerHealth = PlayerHealth - 15;
                                                if (PlayerHealth <= 0)
                                                {
                                                    Console.WriteLine("The player has died!");
                                                    playing = false;
                                                    break;
                                                }
                                            }
                                        }
                                        if (SpiderHealth <= 0)
                                        {
                                            Console.WriteLine("The spider has been defeated!");
                                        }
                                    }
                                }
                                break;
                            case 4:
                                Console.WriteLine("You approach the bed to finally accept victory after this horrid experience");
                                playing = false;
                                break;

                        }
                        break;
                    case 6:
                        if (RoomCounter == 4)
                        {
                            Console.WriteLine("You can go no further, you have won, congrats!");
                            playing = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You are moving through the door into the next room");
                            RoomCounter++;
                            DisplayRoom();
                        }
                        break;
                }
            }    
            
            Console.WriteLine("");
            Console.WriteLine("GAME OVER");
            Console.WriteLine();
            DisplayName();
            DisplayHealth();
            DisplayInv();
        }
        void DisplayName()
        {
            Console.WriteLine($"Name:{Player1.Name}");
        }
        void DisplayHealth()
        {
            Console.WriteLine($"Health:{Player1.Health}");
        }
        void DisplayRoom()
        {
            if (RoomCounter == 1)
            {
                Console.WriteLine($"RoomDescription:{StartRoom.GetDescription()}");
            }
            if (RoomCounter == 2)
            {
                Console.WriteLine($"RoomDescription:{Corridor.GetDescription()}");
            }
            if (RoomCounter == 3)
            {
                Console.WriteLine($"RoomDescription:{BossRoom.GetDescription()}");
            }
            if (RoomCounter == 4)
            {
                Console.WriteLine($"RoomDescription:{EndRoom.GetDescription()}");
            }

        }
        void DisplayInv()
        {
            Console.WriteLine($"Inv:{Player1.InventoryContents()}");
        }
    }
}