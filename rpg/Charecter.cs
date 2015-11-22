using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
    public abstract class Charecter
    {
        public abstract string Skill1(List<Charecter> targets);
        //public abstract string Skill2();

        private Charecter target;
        public Charecter Target
        {
            get { return target; }
            set { target = value; }
        }
        private int hp;
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        private int mp;
        public int Mp
        {
            get { return mp; }
            set { mp = value; }
        }
        private int power;
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        private int armor;
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        private double evasion;
        public virtual double Evasion
        {
            get { return evasion; }
            set { evasion = value; }
        }
    }
}
