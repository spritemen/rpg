using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
    public class Ninja : Charecter
    {
        public Ninja(int hp, int mp, int power, int armor, double evasion)
        {
            this.Hp = hp;
            this.Mp = mp;
            this.Power = power;
            this.Armor = armor;
            this.Evasion = evasion;

        }

        public override string Skill1(List<Charecter> targets)
        {
            if (this.Mp >= 120)
            {
                targets[0].Armor -= 1;
                targets[0].Hp -= (this.Power - targets[0].Armor);
                Mp -= 120;
                return "Съешь сюрикен!";
            }
            else
                return "Недостаточно маны";
        }
    }
}
