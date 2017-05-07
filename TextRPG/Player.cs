using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Player : Character
    {
        public List<Item> inventory = new List<Item>();
        
        public int xp;
        public int xpToLevel;

        private Random rand = new Random(Guid.NewGuid().GetHashCode());

        public Player(string name, int maxHealth)
        {
            this.name = name;
            this.level = 1;
            this.xp = 0;
            this.xpToLevel = CalculateXPToLevel();
            this.health = maxHealth;
            this.maxHealth = maxHealth;
            dice = 20;
            this.initiative = rand.Next(1, dice);
        }

        public void AddExperience(int amount)
        {
            xp += amount;
            if (xp >= xpToLevel)
                LevelUp();
            else
                xp += amount;
        }

        private void LevelUp()
        {
            this.level += level;
            xp = 0;
            CalculateXPToLevel();

            Console.WriteLine("Leveled up! {0} is now level {1}", name, level);
            Console.WriteLine();
        }

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

        public int CalculateXPToLevel()
        {
            xpToLevel = level * 100;
            return xpToLevel;
        }
    }
}
