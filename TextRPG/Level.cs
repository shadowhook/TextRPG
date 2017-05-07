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

        public Level(string description, List<char> exits, List<Enemy> enemies)
        {
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
            Console.Write("Exits: ");
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
                    if(index == exits.Count)
                        Console.WriteLine("{0}", c);
                    else
                        Console.Write("{0}, ", c);
                }
            }
           
        }
    }
}
