using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class LevelTwo
    {
        public static List<char> exits = new List<char>();
        public static List<Enemy> enemies = new List<Enemy>();

        public static string Description;

        public static Level Create()
        {
            enemies.Add(new Enemy("Dragon", 5, 100, 4, 500));
            Description = "There is an evil dragon. It hasn't noticed you yet.";


            return new Level(2, Description, exits, enemies);
        }
    }
}
