using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Enemy : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        public Enemy(string name, int life, int maxLife, int blockChance, int hitChance, int minDamage, int maxDamage, string description) : base(name, life, maxLife, blockChance, hitChance)
        {
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
        }

        public override string ToString()
        {
            return string.Format($"{Name}\nDescription: {Description}\nThis monster appears to be {(Life == MaxDamage ? "uninjured" : Life <= MaxLife * .25 ? "close to death" : "injured")}");
        }

        public override int CalculateDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
