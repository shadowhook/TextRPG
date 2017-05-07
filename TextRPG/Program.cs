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
            /*
            Player player = new Player("Cameron", 100);
            Enemy spider = new Enemy("Spider", 100, 4, 100);

            Console.WriteLine("Player health: {0}", player.health);
            Console.WriteLine("Spider health: {0}", spider.health);

            Console.WriteLine();

            Console.WriteLine("Player initiative: {0}", player.initiative);
            Console.WriteLine("Spider initiative: {0}", spider.initiative);

            Console.WriteLine();


            while(spider.IsAlive() && player.IsAlive())
            {
                player.IsTurn(spider);
                player.Attack(spider);
                Console.WriteLine();
                Console.ReadKey();
            }
            */

            List<char> firstLevelExits = new List<char>();
            firstLevelExits.Add('N');

            List<Enemy> firstLevelEnemies = new List<Enemy>();
            firstLevelEnemies.Add(new Enemy("Spider", 40, 4, 50));
            firstLevelEnemies.Add(new Enemy("Spider", 40, 4, 50));
            Level firstLevel = new Level("This is the first level.", firstLevelExits, firstLevelEnemies);

            Console.WriteLine("{0}", firstLevel.description);
            firstLevel.ListEnemies();
            firstLevel.ListExits();

            // DO NOT REMOVE
            Console.ReadKey();
        }
    }
}
