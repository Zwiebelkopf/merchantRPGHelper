﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    public class Hero {
        public readonly int Id;
        public readonly string Name;
        public int Level;
        public readonly double Strength;
        public readonly double Intelligence;
        public readonly double Dexterity;

        public readonly double StartHP;
        public readonly double StartAttack;
        public readonly double StartMagicAttack;
        public readonly double StartAccuracy;
        public readonly double StartCriticalRate;
        public readonly double StartDefense;
        public readonly double StartMagicDefense;

        public readonly double LevelHP;
        public readonly double LevelAttack;
        public readonly double LevelMagicAttack;
        public readonly double LevelAccuracy;
        public readonly double LevelCriticalRate;
        public readonly double LevelDefense;
        public readonly double LevelMagicDefense;

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
        }

        public override string ToString() {
            return Name;
        }
    }

    /*public class HeroChooserValue {
        private string dataName ;
        private int dataValue ;

        public HeroChooserValue(Hero hero) {
            DataName = hero.Name;
            DataValue = hero.Id;
        }

        public string DataName
        {
            get{ return dataName ;}
            set{ dataName = value ; }
        }

        public int DataValue
        {
            get{ return dataValue ;}
            set{ dataValue = value ; }
        }

        public override string ToString()
        {
            return dataName ;
        }
    }*/
}
