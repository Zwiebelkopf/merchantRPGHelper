using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Equipment))]
    [System.Xml.Serialization.XmlInclude(typeof(HeroSkills))]
    public class Hero {
        public readonly int Id;
        public string Name;
        public int Level;
        public double Strength;
        public double Intelligence;
        public double Dexterity;

        public double StartHP;
        public double StartAttack;
        public double StartMagicAttack;
        public double StartAccuracy;
        public double StartCriticalRate;
        public double StartDefense;
        public double StartMagicDefense;

        public double LevelHP;
        public double LevelAttack;
        public double LevelMagicAttack;
        public double LevelAccuracy;
        public double LevelCriticalRate;
        public double LevelDefense;
        public double LevelMagicDefense;

        public Equipment Inventar;
        public HeroSkills Skills;

        public Hero() {}

        public Hero(int id, string name, double strength, double intelligence, double dexterity, double startHP, double startAttack, double startMagicAttack, double startAccuracy, double startCriticalRate, double startDefense, double startMagicDefense, double levelHP, double levelAttack, double levelMagicAttack, double levelAccuracy, double levelCriticalRate, double levelDefense, double levelMagicDefense) {
            this.Id = id;
            this.Name = name;
            this.Level = 1;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.StartHP = startHP;
            this.StartAttack = startAttack;
            this.StartMagicAttack = startMagicAttack;
            this.StartAccuracy = startAccuracy;
            this.StartCriticalRate = startCriticalRate;
            this.StartDefense = startDefense;
            this.StartMagicDefense = startMagicDefense;
            this.LevelHP = levelHP;
            this.LevelAttack = levelAttack;
            this.LevelMagicAttack = levelMagicAttack;
            this.LevelAccuracy = levelAccuracy;
            this.LevelCriticalRate = levelCriticalRate;
            this.LevelDefense = levelDefense;
            this.LevelMagicDefense = levelMagicDefense;
            Inventar = new Equipment();
            Skills = new HeroSkills();
        }

        public Hero(Hero another) {
            this.Id = another.Id;
            this.Name = another.Name;
            this.Level = another.Level;
            this.Strength = another.Strength;
            this.Intelligence = another.Intelligence;
            this.Dexterity = another.Dexterity;
            this.StartHP = another.StartHP;
            this.StartAttack = another.StartAttack;
            this.StartMagicAttack = another.StartMagicAttack;
            this.StartAccuracy = another.StartAccuracy;
            this.StartCriticalRate = another.StartCriticalRate;
            this.StartDefense = another.StartDefense;
            this.StartMagicDefense = another.StartMagicDefense;
            this.LevelHP = another.LevelHP;
            this.LevelAttack = another.LevelAttack;
            this.LevelMagicAttack = another.LevelMagicAttack;
            this.LevelAccuracy = another.LevelAccuracy;
            this.LevelCriticalRate = another.LevelCriticalRate;
            this.LevelDefense = another.LevelDefense;
            this.LevelMagicDefense = another.LevelMagicDefense;
            Inventar = another.Inventar;
            Skills = another.Skills;
        }

        public void Equip(Item what) {
            Inventar.Equip(what);
        }

        public void SelectSkill(char pos, Skill skill) {
            switch (pos) {
                case 'P':
                    Skills.Passive = skill;
                    break;
                case '1':
                    Skills.Round1 = skill;
                    break;
                case '2':
                    Skills.Round1 = skill;
                    break;
                case '3':
                    Skills.Round1 = skill;
                    break;
                case '4':
                    Skills.Round1 = skill;
                    break;
                case '5':
                    Skills.Round1 = skill;
                    break;
            }
        }

        public override string ToString() {
            return Name;
        }

        public double GetRealValue(string what) {
            double erg = 0;

            // Stats
            switch (what) {
                case "Attack":
                    erg = StartAttack + LevelAttack * (Level);
                    break;
                case "MagicAttack":
                    erg += StartMagicAttack + LevelMagicAttack * (Level);
                    break;
                case "Accuracy":
                    erg += StartAccuracy + LevelAccuracy * (Level);
                    break;
                case "Defense":
                    erg += StartDefense + LevelDefense * (Level);
                    break;
                case "MagicDefense":
                    erg += StartMagicDefense + LevelMagicDefense * (Level);
                    break;
                case "Critical":
                    erg += StartCriticalRate + LevelCriticalRate * (Level);
                    break;
                case "HP":
                    erg += StartHP + Level * LevelHP;
                    break;
            }

            // Items
            foreach (var entry in Inventar.ToArray()) {
                switch (what) {
                    case "Attack":
                        // reiner Attack Value
                        erg += entry.Attack + entry.Strength;
                        break;
                    case "MagicAttack":
                        erg += entry.MagicAttack + entry.Intelligence;
                        break;
                    case "Accuracy":
                        erg += entry.Accuracy + entry.Dexterity;
                        break;
                    case "Defense":
                        erg += entry.Defense;
                        break;
                    case "MagicDefense":
                        erg += entry.MagicDefense;
                        break;
                    case "Critical":
                        erg += entry.CriticalRate;
                        break;
                    case "Strength":
                        erg += entry.Strength;
                        break;
                    case "Intelligence":
                        erg += entry.Intelligence;
                        break;
                    case "Dexterity":
                        erg += entry.Dexterity;
                        break;
                    case "HP":
                        erg += entry.HP;
                        break;
                }
            }

            // Skills
            if (Skills.Passive != null) {
                switch (what) {
                    case "HP":
                        erg = erg * Skills.Passive.RaiseHP;
                        break;
                }
            }

            return erg;
        }

    }

    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Item))]
    public class Equipment {

        public Item weapon;
        public Item helm;
        public Item chest;
        public Item gloves;
        public Item boots;
        public Item trinket;

        public Equipment() {}

        public Item GetSlot(ItemSlot slot) {
            switch (slot) {
                case ItemSlot.Weapon:
                    return weapon;
                case ItemSlot.Helm:
                    return helm;
                case ItemSlot.Chest:
                    return chest;
                case ItemSlot.Gloves:
                    return gloves;
                case ItemSlot.Boots:
                    return boots;
                case ItemSlot.Trinket:
                    return trinket;
            }
            return null;
        }

        public void Equip(Item what){
            switch(what.Slot){
                case ItemSlot.Weapon:
                    weapon = what;
                    break;
                case ItemSlot.Helm:
                    helm = what;
                    break;
                case ItemSlot.Chest:
                    chest = what;
                    break;
                case ItemSlot.Gloves:
                    gloves = what;
                    break;
                case ItemSlot.Boots:
                    boots = what;
                    break;
                case ItemSlot.Trinket:
                    trinket = what;
                    break;
            }
        }

        public Item[] ToArray() {
            Item[] erg = new Item[6];

            erg[0] = weapon;
            erg[1] = helm;
            erg[2] = chest;
            erg[3] = gloves;
            erg[4] = boots;
            erg[5] = trinket;

            return erg;
        }
    }
}
