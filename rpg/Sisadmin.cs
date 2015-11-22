using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
    public class Sisadmin : Charecter
    {
        public Sisadmin(int hp, int mp, int power, int armor, int evasion)
        {
            this.Hp = hp;
            this.Mp = mp;
            this.Power = power;
            this.Armor = armor;
        }
        public override double Evasion
        {
            get
            {
                return base.Evasion;
            }
            set
            {
                base.Evasion = (int)value;
            }
        }
        public override string Skill1(List<Charecter> targets)
        {
            if (this.Mp >= 100)
            {
                targets[0].Hp += this.Power * 3;
                Mp -= 100;
                return "Никто из моей команды не умрёт!";
            }
            else
                return "Недостаточно маны";

        }
    }
}
