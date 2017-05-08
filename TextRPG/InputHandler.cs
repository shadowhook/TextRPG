using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class InputHandler
    {
        public static void Menu(Level level, Player player)
        {
            if(level.active)
            {
                Console.WriteLine(level.description);
            }
           
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
                    if (Movement(level) == 1 && level.id == 1)
                    {
                        level.active = false;
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        public static int Movement(Level level)
        {
            Console.WriteLine("The possible exits are: ");
            level.ListExits();

            Console.WriteLine("Which direction would you like to go?");
            Console.Write("> ");
            int direction = Convert.ToInt32(Console.ReadLine());
            return direction;
        }
    }
}
