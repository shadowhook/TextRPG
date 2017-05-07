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
            Enemy spider = new Enemy("Spider", 100, 100);

            Console.WriteLine("Player health: {0}", player.health);
            Console.WriteLine("Spider health: {0}", spider.health);

            Console.WriteLine("Player initiative: {0}", player.initiative);
            Console.WriteLine("Spider initiative: {0}", spider.initiative);


            while(spider.IsAlive())
            {
                Console.WriteLine("Is it player's turn? {0}", player.IsTurn(spider));
                player.Attack(spider);
                Console.WriteLine();
                Console.ReadKey();
            }

            // DO NOT REMOVE
            Console.ReadKey();
        }
    }
}
