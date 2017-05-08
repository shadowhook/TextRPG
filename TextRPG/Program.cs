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

            Level mylevel = LevelOne.Create();
            mylevel.active = true;

            InputHandler.Menu(mylevel, player);

            Level secondLevel = LevelTwo.Create();
            if(InputHandler.Movement(mylevel) == 1)
                secondLevel.active = true;

            // DO NOT REMOVE
            Console.ReadKey();
        }
    }
}
