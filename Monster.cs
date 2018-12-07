using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    public class Monster {
        public readonly string Name;
        public readonly int Level;
        public readonly int MaxPartyMembers;

        public readonly double Attack;
        public readonly double MagicAttack;
        public readonly double Evasion;

        public readonly double Defense;
        public readonly double MagicDefense;
        public readonly double HP;

        public readonly bool AttackFirst;

        public HeroSkills Skills;

        public Monster(string name, int level, double attack, double magicAttack, double evasion, double defense, double magicDefense, double hp, int maxPartyMembers = 1, bool first = false) {
            this.Name = name;
            this.Level = level;
            this.MaxPartyMembers = maxPartyMembers;
            this.Attack = attack;
            this.MagicAttack = magicAttack;
            this.Evasion = evasion;
            this.Defense = defense;
            this.MagicDefense = magicDefense;
            this.HP = hp;
            AttackFirst = first;
            Skills = new HeroSkills();
        }

        public override string ToString() {
            return Name;
        }

        public Skill GetSkill(int round) {
            Skill erg = null;

            switch (round) {
                case 1:
                    erg = Skills.Round1;
                    break;
                case 2:
                    erg = Skills.Round2;
                    break;
                case 3:
                    erg = Skills.Round3;
                    break;
                case 4:
                    erg = Skills.Round4;
                    break;
                case 5:
                    erg = Skills.Round5;
                    break;
            }

            return erg;
        }
    }
}
