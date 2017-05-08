using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Player : Character
    {
        // Contains the player's inventory.
        public List<Potion> inventory = new List<Potion>();
        
        // XP and leveling up are unique to the player.
        public int xp;
        public int xpToLevel;

        // Random number generator
        private Random rand = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Constructor for Player.
        /// </summary>
        /// <param name="name">Name of the player</param>
        /// <param name="maxHealth">Maximum amount of health</param>
        public Player(string name, int maxHealth)
        {
            this.name = name;
            this.level = 1;
            this.xp = 0;
            this.xpToLevel = 100;
            this.health = maxHealth;
            this.maxHealth = maxHealth;
            dice = 20;
            this.initiative = rand.Next(1, dice);
        }

        /// <summary>
        /// Add XP to the player.
        /// </summary>
        /// <param name="amount">The amount of XP to add</param>
        public void AddExperience(int amount)
        {
            xp += amount;
            if (xp >= xpToLevel)
                LevelUp();
            else
                xp += amount;
        }

        /// <summary>
        /// Helper function. Levels the player up and displays a message.
        /// </summary>
        private void LevelUp()
        {
            this.level += level;
            xp = 0;
            CalculateXPToLevel();

            Console.WriteLine("Leveled up! {0} is now level {1}", name, level);
            Console.WriteLine();
        }

        /// <summary>
        /// Retrieves the player's inventory.
        /// </summary>
        public void GetInventory()
        {
            Console.Write("{0}'s inventory: ", this.name);

            if(inventory.Count() <= 0)
            {
                Console.WriteLine("None");
            }
            else if(inventory.Count() == 1)
            {
                foreach (Item i in inventory)
                {
                    Console.WriteLine("{0}", i.name);
                }
            }
            else
            {
                int index = 0;

                foreach(Item i in inventory)
                {
                    ++index;

                    if(index < inventory.Count)
                    {
                        Console.Write("{0}, ", i.name);
                    }
                    else if(index == inventory.Count)
                    {
                        Console.WriteLine("{0}", i.name);
                    }
                }
            }
        }

        /// <summary>
        /// Calculates the amount of XP till the next level.
        /// </summary>
        /// <returns></returns>
        public void CalculateXPToLevel()
        {
            xpToLevel = level * 100;
        }
    }
}
