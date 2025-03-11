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
                Testing test = new Testing();
                test.Testing2();
                Console.WriteLine("TESTING COMPLETED");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Clear(); //Comment this line out if you would like to see the testing happen in the conosle
            }
            try
            {
                Game game = new Game();
                game.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Exit();
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
