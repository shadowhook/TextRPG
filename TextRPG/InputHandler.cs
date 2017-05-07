using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class InputHandler
    {
        public static void Menu(Level level, Player player, Enemy enemy)
        {
            Console.WriteLine(level.description);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Move");
            Console.WriteLine("3. View character sheet.");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Combat.Engage(level, player);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
}
