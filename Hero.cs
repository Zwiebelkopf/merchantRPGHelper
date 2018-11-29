using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
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

        public Dictionary<ItemSlot, Item> Equipment;

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

            //Library bibo = new Library();
            Equipment = new Dictionary<ItemSlot, Item>(); /*{
                { "Weapon",  bibo.Items.First(x => x.Slot == ItemSlot.Weapon) },
                { "Head", bibo.Items.First(x => x.Slot == ItemSlot.Helm) },
                { "Chest",  bibo.Items.First(x => x.Slot == ItemSlot.Chest) },
                { "Hand", bibo.Items.First(x => x.Slot == ItemSlot.Gloves) },
                { "Foot",  bibo.Items.First(x => x.Slot == ItemSlot.Boots) },
                { "Trinket", bibo.Items.First(x => x.Slot == ItemSlot.Trinket) }
            };*/
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
            Equipment = another.Equipment;
        }

        public void Equip(Item what) {
            if (Equipment.ContainsKey(what.Slot)){
                Equipment[what.Slot] = what;
            }
            else{
                Equipment.Add(what.Slot, what);
            }
            
        }

        public override string ToString() {
            return Name;
        }

        public double GetRealAttack() {
            // Wert ohne Equipment
            double erg = StartAttack + LevelAttack * (Level-1);

            foreach (var entry in Equipment) {
                // reiner Attack Value
                erg += entry.Value.Attack;
                // Strength Modifier
            }

            return erg;
        }
    }
}
