using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _damageMin;

        public int DamageMax { get; set; }
        public string Description { get; set; }
        public int DamageMin
        {
            get { return _damageMin; }
            set { _damageMin = value > 0 && value <= DamageMax ? value : 1; }//end set
        }//end prop DamageMin

        //FQCTOR
        public Monster(string name, int life, int maxLife, int blockChance, int hitChance, int damageMax, string description, int damageMin) : base(name, life, maxLife, blockChance, hitChance)
        {
            DamageMax = damageMax;
            Description = description;
            DamageMin = damageMin;
        }//END Monster FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}\n" +
                $"{(Life == MaxLife ? "It is uninjured" : Life <= MaxLife * .25 ? "The monster appears to be severely wounded!" : "It is slightly injured")}");
        }

        public override int CalculateDamage()
        {
            return new Random().Next(DamageMin, DamageMax + 1);
        }
    }
}
