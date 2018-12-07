using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {

    class Battle {
        private Dictionary<int, Hero> gruppe;
        private Monster mon;
        private Form1 parent;

        public Battle(Form1 parent, Dictionary<int, Hero> gruppe, Monster mon) {
            this.gruppe = gruppe;
            this.mon = mon;
            this.parent = parent;
        }

        public string Fight(){
            string log = ""; // Battlelog
            double temp = 0; // damagevalue
            double dmgToEnemy = 0;
            int round = 1;   // round counter max 200 ... % 5 = 0-4 for what skill to use.
            Skill useSkill;

            while (mon.HP - dmgToEnemy > 0 && round <= 200) {
                log += "Turn #" + round + " started" + Environment.NewLine + Environment.NewLine;

                // our Heroes attack / heal / buff
                foreach (KeyValuePair<int, Hero> entry in gruppe) {
                    // do something with entry.Value or entry.Key

                    useSkill = entry.Value.GetSkill(round % 5);
                    log += entry.Value.Name + " uses " + useSkill.Name + Environment.NewLine;
                    temp = 0;

                    //Damage=100100+Enemy Defense×(Hero Attack×Skill Modifier)
                    if (useSkill.DealPatk > 0) {
                        temp += (100.0 / (100.0 + mon.Defense)) * (entry.Value.GetRealValue("Attack", false) * useSkill.DealPatk);
                    }
                    if (useSkill.DealMatk > 0) {
                        temp += (100.0 / (100.0 + mon.MagicDefense)) * (entry.Value.GetRealValue("MagicAttack", false) * useSkill.DealPatk);
                    }
                    if (useSkill.DealAcc > 0) {
                        temp += (100.0 / (100.0 + mon.Defense)) * (entry.Value.GetRealValue("Accuracy", false) * useSkill.DealAcc);
                    }

                    temp = Math.Round(temp, 0);
                    dmgToEnemy += temp;

                    log += mon.Name + " takes " + temp + " DMG" + Environment.NewLine;
                    if (this.mon.HP - dmgToEnemy <= 0)
                        log += mon.Name + " fainted";
                    log += Environment.NewLine;
                }

                if (this.mon.HP - dmgToEnemy > 0) {

                    Dictionary<int, Hero> frontrow = new Dictionary<int,Hero>(), 
                        backrow = new Dictionary<int,Hero>(),
                        attackThem = new Dictionary<int,Hero>();
                    int teiler = 0;
                    bool attackFront = true;

                    // the evil enemy does some shit
                    useSkill = mon.GetSkill(round % 5) ?? parent.basicSkill; // If monster's skill is null then use basic
                    log += this.mon.Name + " uses " + useSkill.Name + Environment.NewLine;
                    // IF useSkill.Backrow THEN attackFront = false

                    if (gruppe.ContainsKey(2) || gruppe.ContainsKey(4) || gruppe.ContainsKey(6)) { // Frontrow intact
                        attackFront = true;
                        if (gruppe.ContainsKey(2)) {
                            teiler++;
                            frontrow.Add(2, gruppe[2]);
                        }
                        if (gruppe.ContainsKey(4)) {
                            teiler++;
                            frontrow.Add(4, gruppe[4]);
                        }
                        if (gruppe.ContainsKey(6)) {
                            teiler++;
                            frontrow.Add(6, gruppe[6]);
                        }
                    }
                    else {
                        attackFront = false;
                        if (gruppe.ContainsKey(1)) {
                            teiler++;
                            backrow.Add(1, gruppe[1]);
                        }
                        if (gruppe.ContainsKey(3)) {
                            teiler++;
                            backrow.Add(3, gruppe[3]);
                        }
                        if (gruppe.ContainsKey(5)) {
                            teiler++;
                            backrow.Add(5, gruppe[5]);
                        }
                    }

                    if (attackFront)
                        attackThem = frontrow;
                    else
                        attackThem = backrow;

                    foreach (KeyValuePair<int, Hero> entry in attackThem) {
                        temp = 0; // damage
                        if (useSkill.DealPatk > 0) {
                            temp += (100 / (100 + gruppe[4].GetRealValue("Defense", false))) * (this.mon.Attack * useSkill.DealPatk / teiler);
                        }
                        if (useSkill.DealMatk > 0) {
                            temp += (100 / (100 + gruppe[4].GetRealValue("Defense", false))) * (this.mon.Attack * useSkill.DealPatk / teiler);
                        }
                        log += entry.Value.Name + " takes " + temp + " DMG" + Environment.NewLine;
                    }

                    log += Environment.NewLine + Environment.NewLine;
                }

                round++;
            }
            return log;
        }
    }
}
