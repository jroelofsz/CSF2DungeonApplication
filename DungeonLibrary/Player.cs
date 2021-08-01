using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public Weapon EquippedWeapon { get; set; }
        public Race PlayerRace { get; set; }

        public Player(string name, int life, int maxLife, int blockChance, int hitChance, Weapon equippedWeapon, Race playerRace) : base(name, life, maxLife, blockChance, hitChance)
        {
            EquippedWeapon = equippedWeapon;
            PlayerRace = playerRace;
            switch (PlayerRace)
            {
                case Race.Altmer:
                    Life -= 10;
                    MaxLife -= 10;
                    HitChance += 10;
                    BlockChance += 5;
                    break;
                case Race.Argonian:
                    Life += 10;
                    MaxLife += 10;
                    HitChance -= 5;
                    BlockChance -= 5;
                    break;
                case Race.Bosmer:
                    Life -= 10;
                    MaxLife -= 10;
                    HitChance += 10;
                    BlockChance += 5;
                    break;
                case Race.Breton:
                    Life += 10;
                    MaxLife += 10;
                    HitChance -= 5;
                    BlockChance -= 5;
                    break;
                case Race.Dunmer:
                    Life += 5;
                    MaxLife += 5;
                    HitChance += 5;
                    BlockChance -= 10;
                    break;
                case Race.Khajit:
                    Life -= 10;
                    MaxLife -= 10;
                    HitChance += 10;
                    BlockChance += 5;
                    break;
                case Race.Nord:
                    Life += 10;
                    MaxLife += 10;
                    HitChance -= 5;
                    BlockChance -= 5;
                    break;
                case Race.Orsimer:
                    Life += 10;
                    MaxLife += 10;
                    HitChance -= 5;
                    BlockChance -= 5;
                    break;
                case Race.Redguard:
                    Life -= 10;
                    MaxLife -= 10;
                    HitChance += 10;
                    BlockChance += 5;
                    break;
                default:
                    break;
            }

        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\nRace: {PlayerRace}\nLife{Life}\nEquipped Weapon: {EquippedWeapon}");
        }

        public override int CalculateDamage()
        {
            int damage = new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalculateHitChance()
        {
            return HitChance + EquippedWeapon.HitChanceBonus;
        }
    }
}
