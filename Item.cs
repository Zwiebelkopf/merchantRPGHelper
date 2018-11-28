using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
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
            if (Slot == ItemSlot.Weapon)
                return "Att: " + Attack + " MAtt: " + MagicAttack + " Acc: " + Accuracy;
            else if (Slot == ItemSlot.Trinket)
                return "";
            else
                return "Def: " + Defense + " MDef: " + MagicDefense;
        }
    }

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
