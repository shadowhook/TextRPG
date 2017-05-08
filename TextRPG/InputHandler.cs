using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class InputHandler
    {
        /// <summary>
        /// Show the main menu based on the level.
        /// </summary>
        /// <param name="level">The level the player is on</param>
        /// <param name="player">The player object</param>
        public static void Menu(Level level, Player player)
        {
            if(level.active)
            {
                Console.WriteLine(level.description);
            }
           
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use item");
            Console.WriteLine("3. View character sheet.");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Console.WriteLine();
                    Combat.Engage(level, player);
                    break;
                case 2:
                    if(player.inventory.Count > 0)
                    {
                        player.inventory[0].Use(player);
                        Console.WriteLine("Used {0} to heal for {1} HP.", player.inventory[0].name, player.inventory[0].potency);
                        Console.WriteLine("{0} has {1} HP", player.name, player.health);

                        Console.WriteLine();
                       
                        player.inventory.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("No inventory.");
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Player name: {0}", player.name);
                    Console.WriteLine("Player health: {0} / {1} ", player.health, player.maxHealth);
                    player.GetInventory();
                    Console.WriteLine();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
