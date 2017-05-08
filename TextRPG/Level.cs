using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Level
    {
        public string description;
        public List<Enemy> enemies;
        public bool active = false;

        /// <summary>
        /// Level constructor
        /// </summary>
        /// <param name="description">Description of level</param>
        /// <param name="enemies">Enemies in level</param>
        public Level(string description, List<Enemy> enemies)
        {
            this.description = description;
            this.enemies = enemies;
        }

        /// <summary>
        /// List the enemies in the level
        /// </summary>
        public void ListEnemies()
        {
            if (enemies.Count <= 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                int index = 0;

                foreach (Enemy e in enemies)
                {
                    ++index;
                    if (index == enemies.Count)
                        Console.WriteLine("{0}", e.name);
                    else
                        Console.Write("{0}, ", e.name);
                }
            }
        }
    }
}