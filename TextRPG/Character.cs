// This class is the base class for characters in the game, such as the Player or Enemies.
using System;

namespace TextRPG
{
    class Character
    {
        public string name;
        public int level, health, maxHealth, initiative, dice;
        public bool firstRound = true;

        private Random rand = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Default constructor for the character class.
        /// </summary>
        public Character()
        {
            this.name = "unknown";
            this.level = 0;
            this.health = 0;
            this.maxHealth = health;
        }

        /// <summary>
        /// Constructor for the character class.
        /// </summary>
        /// <param name="name">The initial name of the character</param>
        /// <param name="level">The initial level of the character</param>
        /// <param name="health">The initial health of the character</param>
        public Character(string name, int level, int health)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.maxHealth = health;
        }

        /// <summary>
        /// Check if the character has been killed.
        /// </summary>
        /// <returns>False if dead, true if alive.</returns>
        public bool IsAlive()
        {
            if(this.health <= 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Set the name of the character
        /// </summary>
        /// <param name="name">The new name of the character</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Set the level of the character
        /// </summary>
        /// <param name="level">The new level of the character</param>
        public void SetLevel(int level)
        {
            this.level = level;
        }

        /// <summary>
        /// Set the health of the character
        /// </summary>
        /// <param name="health">The new health amount of the character</param>
        public void SetHealth(int health)
        {
            this.health = health;
        }

        /// <summary>
        /// Set the max health of the character
        /// </summary>
        /// <param name="amount">The maximum amount of health the character has</param>
        public void SetMaxHealth(int amount)
        {
            this.maxHealth = amount;
        }
    }
}
