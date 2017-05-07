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
        public double damage;
        public bool myTurn;

        public Player(string name, int maxHealth)
        {
            this.name = name;
            this.level = 1;
            this.xp = 0;
            this.xpToLevel = CalculateXPToLevel();
            this.health = maxHealth;
            this.maxHealth = maxHealth;
        }

        public bool IsTurn(Enemy enemy)
        {
            if(firstRound)
            {
                if (this.initiative >= enemy.initiative)
                {
                    myTurn = true;
                }
                else
                {
                    myTurn = false;
                }

                firstRound = false;
            }
            else
            {
                myTurn = !myTurn; 
            }

            return myTurn;
        }

        public void Attack(Enemy enemy)
        {
            Console.WriteLine("{0} attacks {1} for {2} damage.", this.name, enemy.name, (int)GenerateDamage(enemy));
            Console.WriteLine("{0} has {1} HP left.", enemy.name, enemy.health);
        }

        public double GenerateDamage(Enemy enemy)
        {
            Random rand = new Random();

            damage = level * rand.Next(level, level * xpToLevel);
            enemy.health -= (int)damage;

            return damage;
        }

        public void AddExperience(int amount)
        {
            if (this.xp + amount >= xpToLevel)
                LevelUp();
            else
                this.xp += amount;
        }

        private void LevelUp()
        {
            this.level += 1;
            xpToLevel = CalculateXPToLevel() % xp;
            xp = 0;
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
            return xpToLevel = level * 100;
        }
    }
}
