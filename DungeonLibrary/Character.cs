using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //This class will hold the "blueprint" for all characters made in my dungeon application.
        public string Name { get; set; }
        public int Life { get; set; }
        public int  MaxLife { get; set; }
        public int BlockChance { get; set; }
        public int HitChance { get; set; }
        //FQCTOR
        public Character(string name, int life, int maxLife, int blockChance, int hitChance)
        {
            Name = name;
            Life = life;
            MaxLife = maxLife;
            BlockChance = BlockChance;
            HitChance = hitChance;
        }

        //I won't have a ToString() because I want the stats to be displayed differently for Monsters and Characters
        public virtual int CalculateBlockChance()
        {
            return BlockChance;
        }

        public virtual int CalculateHitChance()
        {
            return HitChance;
        }

        public abstract int CalculateDamage();
    }
}
