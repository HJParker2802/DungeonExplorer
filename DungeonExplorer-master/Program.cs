using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("TESTING STARTED");
                Testing test = new Testing();//Creates the test object of class testing
                test.Testing2();//Starts the testing
                Console.WriteLine("TESTING COMPLETED");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);//catches any exceptions and prints them
            }
            finally
            {
                Console.Clear(); //Comment this line out if you would like to see the testing happen in the conosle
            }//Console.Clear is present to remove proof of testing for a more enjoyable user experience
            try
            {
                Game game = new Game();//Creates the game object of class Game
                game.Start();//Starts the game object, starting the game
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);//catches any exceptions that may pop up
            }
            finally
            {
                Exit();//Ensures that at the end of the game, the console gives the user the option to press any key to exit
            }

        }
        static void Exit()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the game....");
            Console.ReadKey();

        }
    }
}
