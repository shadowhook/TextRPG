using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    static class Combat
    {
        public static bool FirstRound = true;

        private static Random rand = new Random(Guid.NewGuid().GetHashCode());

        public static void Engage(Level level, Player player)
        {
            while(level.enemies.Count > 0)
            {
                if(player.IsAlive() && level.enemies[0].IsAlive())
                {
                    PlayerTurn(player, level.enemies[0]);
                    Attack(player, level.enemies[0]);

                    if(!level.enemies[0].IsAlive())
                    {
                        Console.WriteLine("You've killed the {0}", level.enemies[0].name);
                        level.enemies[0].GrantXP(player);
                        level.enemies.RemoveAt(0);
                    }

                    if(!player.IsAlive())
                    {
                        Console.WriteLine("You've died!");
                        Console.ReadKey();
                    }
                }
            }

            if(level.enemies.Count == 0)
            {
                Console.WriteLine("Nothing to engage.");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Determines if it's the player's turn or not.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        /// <returns>True if it's the player's turn, false otherwise.</returns>
        public static bool PlayerTurn(Player player, Enemy enemy)
        {
            if(FirstRound)
            {
                FirstRound = false;
                if(player.initiative >= enemy.initiative)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                player.turn = !player.turn;
                enemy.turn = !enemy.turn;
            }

            return player.turn;
        }

        /// <summary>
        /// Handles attacking, including drawing results to screen.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        public static void Attack(Player player, Enemy enemy)
        {
            CalculateDamage(player, enemy);

            string ply = (player.turn) ? player.name : enemy.name;
            int plyDamage = (player.turn) ? player.damage : enemy.damage;
            string target = (player.turn) ? enemy.name : player.name;
            int targetHealth = (player.turn) ? enemy.health : player.health;

            

            Console.WriteLine("{0} attacks {1} for {2} damage.", ply, target, plyDamage);
            Console.WriteLine("{0} has {1} HP left.", target, targetHealth);

            Console.ReadKey();
            Console.WriteLine();
        }

        /// <summary>
        /// Calculate the amount of damage the character will do this turn.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        /// <returns></returns>
        private static void CalculateDamage(Player player, Enemy enemy)
        {
            player.damage = rand.Next(1, player.dice) * player.level;
            enemy.damage = rand.Next(1, enemy.dice) * enemy.level;

            if(player.turn)
            {
                enemy.health -= player.damage;
            }
            else
            {
                player.health -= enemy.damage;
            }
        }
    }
}
