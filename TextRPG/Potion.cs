using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Potion : Item
    {
        public int potency;

        /// <summary>
        /// Potion constructor that can be called by ID.
        /// </summary>
        /// <param name="id">The ID of the potion.
        /// 1 = Light Potion (Heals: 50)
        /// 2 = Moderate Potion (Heals: 100)
        /// 3 = Heavy Potion (Heals: 150)
        /// 4 = Max Potion (Heals: 200)</param>
        public Potion(int id)
        {
            this.id = id;
            this.quantity += 1;
            this.name = CalculateName();
        }

        /// <summary>
        /// Potion constructor that can be called by name.
        /// </summary>
        /// <param name="name">The name of the potion. Options:
        /// Light Potion (Heals: 50) / ID = 1
        /// Moderate Potion (Heals: 100) / ID = 2
        /// Heavy Potion (Heals: 150) / ID = 3
        /// Max Potion (Heals: 200) / ID = 4</param>
        public Potion(string name)
        {
            this.name = name;
            this.quantity += 1;
            this.id = CalculateID();
        }

        /// <summary>
        /// Uses the potion based on its potency. If the potion puts the player past max health, it'll set the player's health to their max HP.
        /// </summary>
        /// <param name="player">The player object that will be using the potion</param>
        /// <returns>Returns the player's health</returns>
        public void Use(Player player)
        {
            CalculatePotency();

            player.health += potency;
            if(player.health > player.maxHealth)
            {
                player.health = player.maxHealth;
            }
        }

        /// <summary>
        /// Helper function. Calculates the potion of potions based on which type of potion the player has
        /// </summary>
        /// <returns>Returns the potency of the potion</returns>
        public void CalculatePotency()
        {
            switch (id)
            {
                case 1:
                    potency = 50;
                    break;

                case 2:
                    potency = 100;
                    break;

                case 3:
                    potency = 150;
                    break;

                case 4:
                    potency = 200;
                    break;

                default:
                    potency = 0;
                    break;
            }
        }

        /// <summary>
        /// Helper function. Calculates the name of the function based on its ID.
        /// </summary>
        private string CalculateName()
        {
            switch (id)
            {
                case 1:
                    name = "Light Potion";
                    break;
                case 2:
                    name = "Moderate Potion";
                    break;
                case 3:
                    name = "Heavy Potion";
                    break;
                case 4:
                    name = "Max Potion";
                    break;
                default:
                    name = "Unknown Potion";
                    break;
            }

            return name;
        }

        /// <summary>
        /// Helper function. Calculates the ID of the potion based on the name.
        /// </summary>
        private int CalculateID()
        {
            switch(name)
            {
                case "Light Potion":
                    id = 1;
                    break;
                case "Moderate Potion":
                    id = 2;
                    break;
                case "Heavy Potion":
                    id = 3;
                    break;
                case "Max Potion":
                    id = 4;
                    break;
                default:
                    id = 0;
                    break;
            }

            return id;
        }
    }
}
