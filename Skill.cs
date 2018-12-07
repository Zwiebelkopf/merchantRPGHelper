using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Item))]
    public class HeroSkills {
        public Skill Passive;
        public Skill Round1;
        public Skill Round2;
        public Skill Round3;
        public Skill Round4;
        public Skill Round5;

        public HeroSkills() {
            /*Library bibo = new Library();
            Skill skill = bibo.Skills.First(x => x.Name.Equals("Basic"));*/

            Passive = null;
            Round1 = null;
            Round2 = null;
            Round3 = null;
            Round4 = null;
            Round5 = null;
        }

        public void SetSkill(char pos, Skill skill) {
            switch (pos) {
                case 'P':
                    Passive = skill;
                    break;
                case '1':
                    Round1 = skill;
                    break;
                case '2':
                    Round2 = skill;
                    break;
                case '3':
                    Round3 = skill;
                    break;
                case '4':
                    Round4 = skill;
                    break;
                case '5':
                    Round5 = skill;
                    break;
            }
        }

        public string info(int level) {
            int maxAP = 0;

            if (level > 10)
                maxAP = level / 2;
            if (level > 40)
                maxAP = 20;

            int curAP = 0;

            curAP += Round1 != null ? Round1.Cost : 0;
            curAP += Round2 != null ? Round2.Cost : 0;
            curAP += Round3 != null ? Round3.Cost : 0;
            curAP += Round4 != null ? Round4.Cost : 0;
            curAP += Round5 != null ? Round5.Cost : 0;

            return curAP + "/" + maxAP;
        }
    }

    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(int[]))]
    public class Skill {

        public bool IsActive;
        public string Name;
        public int Duration;
        public int Cost;
        public int[] AvailableFor;
        public string Description;

        public double RaisePatk;
        public double RaiseMatk;
        public double RaisePdef;
        public double RaiseMdef;
        public double RaiseHP;
        public double RaiseAcc;
        public double RaiseCritDmg;
        public double RaiseCritChc;

        public double PlusAcc;
        public double PlusCritChc;

        public double DealPatk;
        public double DealMatk;
        public double DealAcc;
        public double DealDef;
        public double DealTrue;

        public double BuffPatk;
        public double BuffDef;

        public bool IgnoreDamage;

        public Skill() { }

        public Skill(string name, bool isactive, int cost, int[] hero_ids, string desc = "", double raisepatk = 1, double raisematk = 1, double raisepdef = 1, 
            double raisemdef = 1, double raisehp = 1, double raiseacc = 1, double raisecritdmg = 1, double raisecritchc = 1,
            double dealpatk = 0, double dealmatk = 0, double dealacc = 0, double dealdef = 0, double dealtrue = 0, int duration = 0,
            double buffpatk = 1, double buffdef = 1, bool ignoredmg = false, double plusacc = 0, double pluscritchc = 0) {
            Name = name;
            IsActive = isactive;
            Cost = cost;
            Duration = duration;
            AvailableFor = hero_ids;
            Description = desc;

            RaisePatk = raisepatk;
            RaiseMatk = raisematk;
            RaisePdef = raisepdef;
            RaiseMdef = raisemdef;
            RaiseHP = raisehp;
            RaiseAcc = raiseacc;
            RaiseCritDmg = raisecritdmg;
            RaiseCritChc = raisecritchc;

            PlusAcc = plusacc;
            PlusCritChc = pluscritchc;

            DealPatk = dealpatk;
            DealMatk = dealmatk;
            DealAcc = dealacc;
            DealDef = dealdef;
            DealTrue = dealtrue;

            BuffPatk = buffpatk;
            BuffDef = buffdef;

            IgnoreDamage = ignoredmg;
        }

        public override string ToString() {
            return Name + " Cost: " + Cost;
        }
    }
}
