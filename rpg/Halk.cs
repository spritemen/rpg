using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
    public class Halk : Charecter
    {
        public Halk(int hp, int mp, int power, int armor, int evasion)
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
            if (this.Mp >= 300)
            {
                this.Power += 5;
                targets[0].Hp -= this.Power;
                Mp -= 300;
                return "Халк разозлился!";
            }
            else
                return "Недостаточно маны";
        }
    }
}
