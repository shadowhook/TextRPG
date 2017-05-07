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

        public Enemy(string name, int level, int health, int dice, int xpGranted)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.dice = dice;
            this.xpGranted = xpGranted;
            this.initiative = new Random(Guid.NewGuid().GetHashCode()).Next(1, dice);
        }

        public void GrantXP(Player player)
        {
            Console.WriteLine("{0} dropped {1} XP", name, xpGranted);
            player.AddExperience(xpGranted);
            RollForPotion(player);
            Console.WriteLine();
        }

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
