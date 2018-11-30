using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(ItemSlot))]
    public class Item {
        public string Name;
        public int Level;
        public ItemSlot Slot;

        public double Attack;
        public double MagicAttack;
        public double Accuracy;
        public double CriticalRate;

        public double Defense;
        public double MagicDefense;

        public double Strength;
        public double Intelligence;
        public double Dexterity;
        public double HP;

        public Item() { }

        public Item(string name, int level, ItemSlot slot, double attack = 0, double magicAttack = 0, double accuracy = 0, double criticalRate = 0, double defense = 0, double magicDefense = 0, double strength = 0, double intelligence = 0, double dexterity = 0, double hp = 0) {
            this.Name = name;
            this.Level = level;
            this.Slot = slot;
            this.Attack = attack;
            this.MagicAttack = magicAttack;
            this.Accuracy = accuracy;
            this.CriticalRate = criticalRate;
            this.Defense = defense;
            this.MagicDefense = magicDefense;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.HP = hp;
        }

        public override string ToString() {
            return Name;
        }

        public string Description() {
            string description = "", zusatz = "";

            if (Slot == ItemSlot.Weapon){
                description = "Att: " + Attack + " MAtt: " + MagicAttack + " Acc: " + Accuracy;
                zusatz += CriticalRate > 0 ? " Crit: " + CriticalRate : "";
                zusatz += Defense > 0 ? " Def: " + Defense : "";
                zusatz += MagicDefense > 0 ? " MDef: " + MagicDefense : "";
                zusatz += Strength > 0 ? " Str: " + Strength : "";
                zusatz += Intelligence > 0 ? " Int: " + Intelligence : "";
                zusatz += Dexterity > 0 ? " Dex: " + Dexterity : "";
                zusatz += HP > 0 ? " HP: " + HP : "";
                return description + (zusatz.Equals("") ? "" : "\n" + zusatz.Trim());
            }
            else if (Slot == ItemSlot.Trinket) {
                zusatz += Attack > 0 ? " Att: " + Attack : "";
                zusatz += MagicAttack > 0 ? " MAtt: " + MagicAttack : "";
                zusatz += Accuracy > 0 ? " Acc: " + Accuracy : "";
                zusatz += CriticalRate > 0 ? " Crit: " + CriticalRate : "";
                zusatz += Defense > 0 ? " Def: " + Defense : "";
                zusatz += MagicDefense > 0 ? " MDef: " + MagicDefense : "";
                zusatz += Strength > 0 ? " Str: " + Strength : "";
                zusatz += Intelligence > 0 ? " Int: " + Intelligence : "";
                zusatz += Dexterity > 0 ? " Dex: " + Dexterity : "";
                zusatz += HP > 0 ? " HP: " + HP : "";
                return zusatz;
            }
            else {
                description = "Def: " + Defense + " MDef: " + MagicDefense;
                zusatz += Attack > 0 ? " Att: " + Attack : "";
                zusatz += MagicAttack > 0 ? " MAtt: " + MagicAttack : "";
                zusatz += Accuracy > 0 ? " Acc: " + Accuracy : "";
                zusatz += CriticalRate > 0 ? " Crit: " + CriticalRate : "";
                zusatz += Strength > 0 ? " Str: " + Strength : "";
                zusatz += Intelligence > 0 ? " Int: " + Intelligence : "";
                zusatz += Dexterity > 0 ? " Dex: " + Dexterity : "";
                zusatz += HP > 0 ? " HP: " + HP : "";

                return description + (zusatz.Equals("") ? "" : "\n" + zusatz.Trim());
            }
                
        }
    }

    [Serializable]
    public enum ItemSlot {
        Weapon,
        Helm,
        Chest,
        Gloves,
        Boots,
        Trinket,
        Boost,
        N
    }
}
