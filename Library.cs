﻿using System;
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
            { "Bard", new Hero(8, "Bard", 2, 2, 2, 60, 2, 2, 2, 1, 6, 6, 7, 0.3, 0.3, 0.3, 0.1, 0.2, 0.2) },
            { "Warrior Prestige 1", new Hero(9, "Warrior Prestige 1", 7, 1, 6, 100, 5, 1, 2, 1, 14, 8, 15, 1, 0.2, 0.6, 0, 1.8, 0.8) },
            { "Rogue Prestige 1", new Hero(10, "Rogue Prestige 1", 6, 1, 8, 90, 5, 1, 2, 5, 9, 8, 12, 1.2, 0.2, 1, 0.2, 1, 0.8) },
            { "Mage Prestige 1", new Hero(11, "Mage Prestige 1", 1, 9, 5, 80, 1, 5, 2, 1, 7, 10, 11, 0.2, 1.8, 0.6, 0, 0.8, 0.8) },
			{ "Berserker Prestige 1", new Hero(12, "Berserker Prestige 1", 9, 1, 5, 90, 5, 1, 2, 1, 10, 7, 12, 1.8, 0.2, 0.6, 0, 1, 0.8) },
			{ "Cleric Prestige 1", new Hero(13, "Cleric Prestige 1", 1, 8, 6, 80, 1, 5, 2, 1, 7, 10, 11, 0.2, 1.2, 1.2, 0, 0.8, 0.8) },
			{ "Assassin Prestige 1", new Hero(14, "Assassin Prestige 1", 5, 1, 8, 90, 5, 1, 2, 10, 9, 8, 12, 1, 0.2, 1.2, 0.4, 1, 0.8) },
			{ "Paladin Prestige 1", new Hero(15, "Paladin Prestige 1", 5, 5, 5, 100, 3, 3, 2, 1, 8, 14, 15, 0.6, 0.6, 0.6, 0, 0.8, 2) },
			{ "Dark Knight Prestige 1", new Hero(16, "Dark Knight Prestige 1", 7, 7, 2, 80, 3, 3, 2, 1, 9, 8, 11, 0.9, 0.9, 0.7, 0, 0.8, 0.8) },
            { "Bard Prestige 1", new Hero(17, "Bard Prestige 1", 5, 5, 5,60, 2, 2, 2, 1, 6, 6,13, 0.6, 0.6, 0.7, 0, 0.4, 0.4) },
        };

        //Hero(id, name, strength, intelligence, dexterity, 
        //      startHP, startAttack, startMagicAttack, startAccuracy, startCriticalRate, startDefense, startMagicDefense, 
        //      levelHP, levelAttack, levelMagicAttack, levelAccuracy, levelCriticalRate, levelDefense, levelMagicDefense) {
        public static Hero[] Heroes = new Hero[] {
			new Hero(0, "Warrior", 5, 1, 4, 			100, 5, 1, 2, 1, 14, 8, 			10, 0.4, 0.1, 0.3, 0, 1, 0.4),
			new Hero(1, "Rogue", 4, 1, 5, 				90, 5, 1, 2, 5, 9, 8, 				8, 0.6, 0.1, 0.5, 0.2, 0.5, 0.4),
			new Hero(2, "Mage", 1, 6, 3, 				80, 1, 5, 2, 1, 7, 10, 				7, 0.1, 0.9, 0.3, 0, 0.4, 0.4),
			new Hero(3, "Berserker", 6, 1, 3, 			90, 5, 1, 2, 1, 10, 7, 				8, 0.8, 0.1, 0.3, 0, 0.5, 0.4),
			new Hero(4, "Cleric", 1, 5, 4, 				80, 1, 5, 2, 1, 7, 10, 				7, 0.1, 0.6, 0.6, 0, 0.4, 0.4),
			new Hero(5, "Assassin", 3, 1, 6, 			90, 5, 1, 2, 10, 9, 8, 				8, 0.4, 0.1, 0.7, 0.2, 0.5, 0.4),
			new Hero(6, "Paladin", 4, 4, 2, 			100, 3, 3, 2, 1, 8, 14, 			10, 0.3, 0.3, 0.3, 0, 0.4, 1),
			new Hero(7, "Dark Knight", 5, 5, 0, 		80, 3, 3, 2, 1, 9, 8, 				7, 0.45, 0.55, 0.3, 0, 0.4, 0.4),
            new Hero(8, "Bard", 2, 2, 2,                60, 2, 2, 2, 1, 6, 6,               7, 0.3, 0.3, 0.3, 0, 0.2, 0.2),
            ///////////////////////////////////////////
            new Hero(9, "Warrior Prestige 1", 7, 1, 6, 				100, 5, 1, 2, 1, 14, 8, 			15, 1, 0.2, 0.6, 0, 1.8, 0.8),
			new Hero(10, "Rogue Prestige 1", 6, 1, 8, 				90, 5, 1, 2, 5, 9, 8, 				12, 1.2, 0.2, 1, 0.2, 1, 0.8),
			new Hero(11, "Mage Prestige 1", 1, 9, 5, 				80, 1, 5, 2, 1, 7, 10, 				11, 0.2, 1.8, 0.6, 0, 0.8, 0.8),
			new Hero(12, "Berserker Prestige 1", 9, 1, 5, 			90, 5, 1, 2, 1, 10, 7, 				12, 1.8, 0.2, 0.6, 0, 1, 0.8),
			new Hero(13, "Cleric Prestige 1", 1, 8, 6, 				80, 1, 5, 2, 1, 7, 10, 				11, 0.2, 1.2, 1.2, 0, 0.8, 0.8),
			new Hero(14, "Assassin Prestige 1", 5, 1, 8, 			90, 5, 1, 2, 10, 9, 8, 				12, 1, 0.2, 1.2, 0.4, 1, 0.8),
			new Hero(15, "Paladin Prestige 1", 5, 5, 5, 			100, 3, 3, 2, 1, 8, 14, 			15, 0.6, 0.6, 0.6, 0, 0.8, 2),
			new Hero(16, "Dark Knight Prestige 1", 7, 7, 2, 		80, 3, 3, 2, 1, 9, 8, 				11, 0.9, 0.9, 0.7, 0, 0.8, 0.8),
            new Hero(17, "Bard Prestige 1", 5, 5, 5,                60, 2, 2, 2, 1, 6, 6,               13, 0.6, 0.6, 0.7, 0, 0.4, 0.4),
		};

        public static Monster[] Monsters = {
			new Monster("Forest Gathering", 1, 0, 0, 0, 5, 5, 20),
			new Monster("Moss Golem", 2, 15, 5, 5, 10, 5, 40),
			new Monster("Forest Treant", 2, 5, 15, 5, 5, 10, 40),
			new Monster("Grass Spider", 3, 5, 20, 10, 5, 10, 50),
			new Monster("Arachne", 3, 5, 30, 15, 5, 10, 65),
			new Monster("Tuvale Viper", 4, 25, 5, 15, 10, 5, 60),
			new Monster("Venom", 4, 35, 10, 15, 10, 5, 70),
			new Monster("Wild Boar", 5, 20, 5, 5, 20, 5, 80),
			new Monster("Hogger", 5, 25, 5, 10, 30, 15, 100),
			new Monster("Goblin Footman", 6, 25, 5, 15, 25, 10, 100),
			new Monster("Grok The Mighty", 6, 35, 5, 20, 30, 10, 110),
			new Monster("Goblin Enchanter", 7, 5, 35, 10, 10, 15, 90),
			new Monster("Siru The Wise", 7, 5, 45, 10, 15, 25, 110),
			new Monster("Goblin Chieftain", 8, 40, 5, 20, 25, 15, 130),
			new Monster("Lord Gronok", 8, 50, 5, 25, 35, 15, 150),
			new Monster("Maexna", 9, 20, 40, 20, 20, 20, 250, maxPartyMembers: 2),
			new Monster("Queen Maexna", 9, 20, 55, 25, 20, 25, 280, maxPartyMembers: 2),
			new Monster("Yarsol Gathering", 10, 0, 0, 0, 10, 10, 70),
			new Monster("Coral Giant", 11, 30, 5, 15, 20, 20, 150),
			new Monster("Water Willow", 11, 5, 30, 15, 20, 20, 150),
			new Monster("Yarsol Snapper", 12, 20, 5, 10, 40, 30, 240),
			new Monster("Wild Turtle", 12, 30, 5, 15, 50, 35, 260),
			new Monster("Murlok Priest", 13, 10, 40, 30, 20, 20, 180),
			new Monster("Murlok Tidecaller", 13, 10, 50, 40, 20, 30, 200),
			new Monster("Sand Lizard", 14, 50, 5, 20, 30, 10, 200),
			new Monster("Leaping Lizzy", 14, 60, 5, 30, 40, 10, 220),
			new Monster("Murlok Spearman", 15, 50, 5, 30, 30, 10, 220),
			new Monster("Murlok Warleader", 15, 60, 5, 35, 35, 15, 240),
			new Monster("Murlok Assassin", 16, 55, 10, 50, 20, 10, 180),
			new Monster("Murlok Tidehunter", 16, 65, 10, 55, 30, 15, 190),
			new Monster("Murlok Highpriest", 17, 10, 70, 30, 20, 20, 220),
			new Monster("Prophet Nami", 17, 10, 80, 45, 25, 30, 250),
			new Monster("Basamus", 18, 110, 5, 30, 50, 30, 500, maxPartyMembers: 2),
			new Monster("Basamus Prime", 18, 130, 5, 30, 65, 35, 550, maxPartyMembers: 2),
			new Monster("Aldur Gathering", 20, 0, 0, 0, 20, 20, 150),
			new Monster("Highland Titan", 21, 50, 5, 30, 40, 20, 250),
			new Monster("Aldur Guardian", 21, 5, 50, 30, 30, 30, 250),
			new Monster("Aldur Ram", 22, 65, 5, 40, 50, 20, 270),
			new Monster("Ceros", 22, 75, 5, 50, 60, 20, 290),
			new Monster("Highland Tunneler", 23, 10, 75, 50, 40, 30, 250),
			new Monster("Terros", 23, 10, 85, 55, 50, 40, 280),
			new Monster("Gnoll Hunter", 24, 75, 5, 60, 55, 15, 300),
			new Monster("Reygar", 24, 90, 5, 60, 60, 20, 320),
			new Monster("Gnoll Shaman", 25, 5, 80, 50, 35, 35, 280),
			new Monster("Kaldar", 25, 5, 100, 60, 40, 40, 290),
			new Monster("Gnoll Overlord", 26, 150, 10, 70, 80, 40, 1000, maxPartyMembers: 3),
			new Monster("Drahgar", 26, 180, 10, 80, 100, 50, 1200, maxPartyMembers: 3),
			new Monster("Ares", 27, 190, 20, 80, 100, 60, 900, maxPartyMembers: 3),
			new Monster("Ares Prime", 27, 220, 30, 90, 130, 70, 1000, maxPartyMembers: 3),
			new Monster("Vulkrum Gathering", 30, 0, 0, 0, 25, 25, 200),
			new Monster("Dark Colossus", 31, 70, 5, 30, 50, 30, 320),
			new Monster("Haunted Harwood", 31, 5, 70, 30, 40, 40, 320),
			new Monster("Nightmare Scorpion", 32, 60, 80, 50, 100, 100, 750, maxPartyMembers: 2),
			new Monster("Scorpinox", 32, 80, 110, 60, 110, 110, 900, maxPartyMembers: 2),
			new Monster("Night Beast", 33, 150, 20, 70, 120, 70, 900, maxPartyMembers: 2),
			new Monster("Night Stalker", 33, 180, 40, 70, 150, 100, 1200, maxPartyMembers: 2),
			new Monster("Undead Warrior", 34, 250, 20, 100, 180, 100, 2500, maxPartyMembers: 3),
			new Monster("Skeletor", 34, 270, 20, 100, 200, 100, 2800, maxPartyMembers: 3),
			new Monster("Undead Mage", 35, 20, 300, 90, 90, 150, 2000, maxPartyMembers: 3),
			new Monster("Altor", 35, 20, 320, 100, 100, 170, 2100, maxPartyMembers: 3),
			new Monster("Antares", 36, 220, 220, 120, 180, 150, 3500, maxPartyMembers: 5),
			new Monster("Serket", 36, 250, 250, 120, 200, 160, 3800, maxPartyMembers: 5),
			new Monster("Lich King", 37, 400, 50, 120, 250, 120, 4000, maxPartyMembers: 5),
			new Monster("Arthus", 37, 440, 60, 120, 280, 140, 4500, maxPartyMembers: 5),
			new Monster("Leviathan", 20, 130, 140, 50, 100, 120, 2100, maxPartyMembers: 5),
			new Monster("Kirin", 30, 380, 140, 90, 260, 140, 2900, maxPartyMembers: 5),
			new Monster("Oni", 40, 450, 150, 120, 360, 200, 5400, maxPartyMembers: 6),
			new Monster("Hel", 40, 200, 540, 120, 180, 280, 4200, maxPartyMembers: 6),
		};

        public static Skill[] Skills = {
            new Skill("Might", false, raisepatk:1.1),
            new Skill("Vitality", false, raisepatk:1.06, raisepdef: 1.12),
            new Skill("Juggernaut", false, raisehp:1.25),
        };
    }
}
