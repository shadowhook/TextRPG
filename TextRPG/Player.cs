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
        public int damage;
        public bool myTurn;

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
            if(myTurn)
            {
                Console.WriteLine("{0} attacks {1} for {2} damage.", this.name, enemy.name, GenerateDamage(enemy));
                Console.WriteLine("{0} has {1} HP left.", enemy.name, enemy.health);
            }
            else
            {
                Console.WriteLine("{0} attacks {1} for {2} damage.", enemy.name, this.name, GenerateDamage(enemy));
                Console.WriteLine("{0} has {1} HP left.", this.name, this.health);
            }
                
        }

        public double GenerateDamage(Enemy enemy)
        {
            damage = rand.Next(1, dice) + level;

            if (myTurn)
                enemy.health -= (int)damage;
            else
                this.health -= (int)damage;

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
