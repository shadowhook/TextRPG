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
            Player player = new Player("Cameron", 100);
            player.SetLevel(1);
            List<char> firstLevelExits = new List<char>();
            firstLevelExits.Add('N');



            List<Enemy> firstLevelEnemies = new List<Enemy>();
            firstLevelEnemies.Add(new Enemy("Spider", 1, 40, 4, 50));
            firstLevelEnemies.Add(new Enemy("Pig", 1, 40, 6, 100));
            Level firstLevel = new Level("This is the first level.", firstLevelExits, firstLevelEnemies);

            Console.WriteLine("{0}", firstLevel.description);
            firstLevel.ListEnemies();
            firstLevel.ListExits();

            InputHandler.Menu(firstLevel, player, firstLevel.enemies[0]);

            // DO NOT REMOVE
            Console.ReadKey();
        }
    }
}
