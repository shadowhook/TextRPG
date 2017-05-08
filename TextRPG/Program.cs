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


            InputHandler.Menu(LevelOne.Create(), player);

            // DO NOT REMOVE
            Console.ReadKey();
        }
    }
}
