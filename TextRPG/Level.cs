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
        public List<char> exits;
        public List<Enemy> enemies;

        public int id;
        public bool active = false;

        public Level(int id, string description, List<char> exits, List<Enemy> enemies)
        {
            this.id = id;
            this.description = description;
            this.exits = exits;
            this.enemies = enemies;
        } 

        public void ListEnemies()
        {
            if(enemies.Count <= 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                int index = 0;

                foreach(Enemy e in enemies)
                {
                    ++index;
                    if(index == enemies.Count)
                        Console.WriteLine("{0}", e.name);
                    else
                        Console.Write("{0}, ", e.name);
                }
            }
        }

        public void ListExits()
        {
            if(exits.Count <= 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                int index = 0;

                foreach (char c in exits)
                {
                    ++index;
                    Console.WriteLine("{0}. {1}", index, c);
                }
            }
           
        }
    }
}
