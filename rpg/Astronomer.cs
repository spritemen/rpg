using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
    public class Astronomer : Charecter
    {
        public Astronomer(int hp, int mp, int power, int armor, int evasion)
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
            if (this.Mp >= 200)
            {
                foreach (Charecter tar in targets)
                {
                    tar.Hp -= (this.Power - tar.Armor);
                }
                this.Mp -= 200;
                return "АРМАГЕДОН!";
            }
            else
                return "Недостаточно маны";
        }
    }
}
