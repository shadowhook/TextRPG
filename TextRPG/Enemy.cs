using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Enemy : Character
    {
        public int xpGranted = 0;

        private Random rand = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Enemy constructor
        /// </summary>
        /// <param name="name">Name of enemy</param>
        /// <param name="level">Level of enemy</param>
        /// <param name="health">Health of enemy</param>
        /// <param name="dice">What die to roll</param>
        /// <param name="xpGranted">Amount of XP granted per kill</param>
        public Enemy(string name, int level, int health, int dice, int xpGranted)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.dice = dice;
            this.xpGranted = xpGranted;
            this.initiative = new Random(Guid.NewGuid().GetHashCode()).Next(1, dice);
        }

        /// <summary>
        /// Grant player XP for kill
        /// </summary>
        /// <param name="player"></param>
        public void GrantXP(Player player)
        {
            Console.WriteLine("{0} dropped {1} XP", name, xpGranted);
            player.AddExperience(xpGranted);
            RollForPotion(player);
            Console.WriteLine();
        }

        /// <summary>
        /// Randomize a roll for a potion
        /// </summary>
        /// <param name="player"></param>
        public void RollForPotion(Player player)
        {
            int random = rand.Next(1, 100);

            if (random >= 50 && random < 75)
            {
                Console.WriteLine("{0} dropped a potion!", name);
                player.inventory.Add(new Potion(1));
                player.GetInventory();
            }
            else if (random >= 75 && random < 85)
            {
                Console.WriteLine("{0} dropped a potion!", name);
                player.inventory.Add(new Potion(2));
                player.GetInventory();
            }
            else if (random >= 85 && random < 95)
            {
                Console.WriteLine("{0} dropped a potion!", name);
                player.inventory.Add(new Potion(3));
                player.GetInventory();
            }
            else if (random >= 95)
            {
                Console.WriteLine("{0} dropped a potion!", name);
                player.inventory.Add(new Potion(4));
                player.GetInventory();
            }            
        }
    }
}
