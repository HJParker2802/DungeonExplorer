using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Testing
    {
       public void Testing2()
        {
            string TestName = "Tester";
            int TestHealth = 12;
            string TestRooomText = "This is a test room, there is a sword on the floor, pick it up!";
            Player TestPlayer = new Player(TestName, TestHealth); // Testing player creation
            Debug.Assert(TestPlayer.Name == TestName);
            Debug.Assert(TestPlayer.Health == TestHealth);
            Room TestRoom = new Room(TestRooomText); //Testing Room Creation
            TestPlayer.PickUpItem("Sword"); //Testing player Pickup
            Console.WriteLine($"PlayerContents: {TestPlayer.InventoryContents()} "); //Testing inventory display
            Console.WriteLine($"Player: {TestPlayer.Name} has health: {TestPlayer.Health}");
            Console.WriteLine($"Player: {TestPlayer.Name} is taking 10 damage");
            TestPlayer.Health = TestPlayer.Health - 10;
            Debug.Assert(TestPlayer.Health == 2);
            Console.WriteLine($"Player: {TestPlayer.Name} has health: {TestPlayer.Health}");
            TestRoom.GetDescription();
            Debug.Assert(TestRoom.GetDescription().ToString() == TestRooomText );
        }
    } 
    
    


}
