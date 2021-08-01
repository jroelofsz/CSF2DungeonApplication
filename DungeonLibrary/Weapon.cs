using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;

        public string WeaponName { get; set; }
        public int HitChanceBonus { get; set; }
        public bool isTwoHanded { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        public Weapon(string weaponName, int hitChanceBonus, int maxDamage, int minDamage, bool IsTwoHanded)
        {
            MaxDamage = maxDamage;
            WeaponName = weaponName;
            HitChanceBonus = HitChanceBonus;
            MinDamage = MinDamage;
            if (IsTwoHanded == true)
            {
                HitChanceBonus -= 5;
            }
            else
            {
                IsTwoHanded = isTwoHanded;
            }
        }

        public override string ToString()
        {
            return string.Format($"{WeaponName}\nDamage: {MinDamage} to {MaxDamage}\n" +
            $"Bonus Hit Chance: {HitChanceBonus}\n");
        }


    }
}
