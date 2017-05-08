using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class LevelOne
    {
        public static List<char> exits = new List<char>();
        public static List<Enemy> enemies = new List<Enemy>();

        public static string Description;

        public static Level Create()
        {
            exits.Add('N');
            enemies.Add(new Enemy("Spider", 1, 40, 4, 50));
            enemies.Add(new Enemy("Pig", 1, 40, 6, 100));
            Description = "Welcome to the first level! Inside, you see a giant pig and spider.\nYou can either test your combat skills now, or proceed to the exits.";

            return new Level(1, Description, exits, enemies);
        }
    }
}
