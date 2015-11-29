using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
    public class Titan : Charecter
    {
        public Titan(int hp, int mp, int power, int armor, int evasion)
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
            if (this.Mp >= 20)
            {
                this.Armor += 2;
                Mp -= 20;
                return "М... Ещё один шлем. Да я скоро буду непобедим!";
            }
            else
                return "Недостаточно маны";
        }

    }
}
