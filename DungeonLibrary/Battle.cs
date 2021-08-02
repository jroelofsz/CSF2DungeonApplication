using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Battle
    {
        public static void Attack(Character attacker, Character defender)
        {
            int rollDice = new Random().Next(1, 101);

            if (rollDice <= attacker.CalculateHitChance() - defender.CalculateBlockChance())
            {
                int damage = attacker.CalculateDamage();
                defender.Life -= damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} dealt {damage} to {defender.Name}!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed {defender.Name}");
            }
        }//end Attack()

        public static void Combat(Player player, Enemy enemy)
        {
            Attack(player, enemy);
            if (enemy.Life > 0)
            {
                Attack(enemy, player);
            }//end if
        }//end Combat()

    }
}
