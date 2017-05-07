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

        public Enemy(string name, int health, int dice, int xpGranted)
        {
            this.name = name;
            this.health = health;
            this.dice = dice;
            this.xpGranted = xpGranted;
            this.initiative = new Random(Guid.NewGuid().GetHashCode()).Next(1, dice);
        }

        public void Attack(Player player)
        {

        }

        public void GrantXP(Player player)
        {
            player.AddExperience(xpGranted);
        }
    }
}
