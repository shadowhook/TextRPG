using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the player's name
            Console.Write("Please enter your player's name: ");
            string plyName = Console.ReadLine();

            // Create new player
            Player player = new Player(plyName, 100);
            player.SetLevel(1);

            // Create first level
            List<Enemy> levelOneEnemies = new List<Enemy>();
            levelOneEnemies.Add(new Enemy("Spider", 1, 40, 4, 50));
            levelOneEnemies.Add(new Enemy("Pig", 1, 60, 4, 100));
            Level levelOne = new Level("This level has two enemies. Pig and spider.", levelOneEnemies);
            levelOne.active = true;

            // Create second level
            List<Enemy> levelTwoEnemies = new List<Enemy>();
            levelTwoEnemies.Add(new Enemy("Dragon", 3, 200, 4, 500));
            Level levelTwo = new Level("This level has one enemy. Dragon.", levelTwoEnemies);
            levelTwo.active = false;

            // While there's still enemies in level one
            while(levelOneEnemies.Count > 0)
            {
                InputHandler.Menu(levelOne, player);
                levelOne.active = false;
                levelTwo.active = true;
            }

            // Once level two is ready, draw it
            if(levelTwo.active)
            {
                while(levelTwoEnemies.Count > 0)
                    InputHandler.Menu(levelTwo, player);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}
