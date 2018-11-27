using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    public static class Library {
        //Hero(name, strength, intelligence, dexterity, 
        //     startHP, startAttack, startMagicAttack, startAccuracy, startCriticalRate, startDefense, startMagicDefense, 
        //     levelHP, levelAttack, levelMagicAttack, levelAccuracy, levelCriticalRate, levelDefense, levelMagicDefense)
        public static Dictionary<string, Hero> Heroes2 = new Dictionary<string, Hero>{
            { "Warrior", new Hero(0, "Warrior", 5, 1, 4, 100, 5, 1, 2, 1, 14, 8, 10, 0.4, 0.1, 0.3, 0, 1, 0.4) },
            { "Rogue", new Hero(1, "Rogue", 4, 1, 5, 90, 5, 1, 2, 5, 9, 8, 8, 0.6, 0.1, 0.5, 0.2, 0.5, 0.4)},
            { "Mage", new Hero(2, "Mage", 1, 6, 3, 80, 1, 5, 2, 1, 7, 10, 7, 0.1, 0.9, 0.3, 0, 0.4, 0.4) },
            { "Berserker", new Hero(3, "Berserker", 6, 1, 3, 90, 5, 1, 2, 1, 10, 7, 8, 0.8, 0.1, 0.3, 0, 0.5, 0.4) },
            { "Cleric", new Hero(4, "Cleric", 1, 5, 4, 80, 1, 5, 2, 1, 7, 10, 7, 0.1, 0.6, 0.6, 0, 0.4, 0.4) },
            { "Assassin", new Hero(5, "Assassin", 3, 1, 6, 90, 5, 1, 2, 10, 9, 8, 8, 0.4, 0.1, 0.7, 0.2, 0.5, 0.4) },
            { "Paladin", new Hero(6, "Paladin", 4, 4, 2, 100, 3, 3, 2, 1, 8, 14, 10, 0.3, 0.3, 0.3, 0, 0.4, 1) },
            { "Dark Knight", new Hero(7, "Dark Knight", 5, 5, 0, 80, 3, 3, 2, 1, 9, 8, 7, 0.45, 0.55, 0.3, 0, 0.4, 0.4) },
            { "Bard", new Hero(8, "Bard", 2, 2, 2, 60, 2, 2, 2, 1, 6, 6, 7, 0.3, 0.3, 0.3, 0.1, 0.2, 0.2) }
        };

        public static Hero[] Heroes = new Hero[] {
			new Hero(0, "Warrior", 5, 1, 4, 
				100, 5, 1, 2, 1, 14, 8, 
				10, 0.4, 0.1, 0.3, 0, 1, 0.4),
			new Hero(1, "Rogue", 4, 1, 5, 
				90, 5, 1, 2, 5, 9, 8, 
				8, 0.6, 0.1, 0.5, 0.2, 0.5, 0.4),
			new Hero(2, "Mage", 1, 6, 3, 
				80, 1, 5, 2, 1, 7, 10, 
				7, 0.1, 0.9, 0.3, 0, 0.4, 0.4),
			new Hero(3, "Berserker", 6, 1, 3, 
				90, 5, 1, 2, 1, 10, 7, 
				8, 0.8, 0.1, 0.3, 0, 0.5, 0.4),
			new Hero(4, "Cleric", 1, 5, 4, 
				80, 1, 5, 2, 1, 7, 10, 
				7, 0.1, 0.6, 0.6, 0, 0.4, 0.4),
			new Hero(5, "Assassin", 3, 1, 6, 
				90, 5, 1, 2, 10, 9, 8, 
				8, 0.4, 0.1, 0.7, 0.2, 0.5, 0.4),
			new Hero(6, "Paladin", 4, 4, 2, 
				100, 3, 3, 2, 1, 8, 14, 
				10, 0.3, 0.3, 0.3, 0, 0.4, 1),
			new Hero(7, "Dark Knight", 5, 5, 0, 
				80, 3, 3, 2, 1, 9, 8, 
				7, 0.45, 0.55, 0.3, 0, 0.4, 0.4),
            new Hero(8, "Bard", 2, 2, 2,
                60, 2, 2, 2, 1, 6, 6,
                7, 0.3, 0.3, 0.3, 0.1, 0.2, 0.2),
		};
    }
}
