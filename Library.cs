﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    public class Library {
        //Hero(name, strength, intelligence, dexterity, 
        //     startHP, startAttack, startMagicAttack, startAccuracy, startCriticalRate, startDefense, startMagicDefense, 
        //     levelHP, levelAttack, levelMagicAttack, levelAccuracy, levelCriticalRate, levelDefense, levelMagicDefense)
        public Hero[] Heroes = new Hero[] {
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
                7, 0.3, 0.3, 0.3, 0, 0.2, 0.2),
            ///////////////////////////////////////////
            new Hero(9, "Warrior Prestige 1", 7, 1, 6,
                100, 5, 1, 2, 1, 14, 8,
                15, 1, 0.2, 0.6, 0, 1.8, 0.8),
			new Hero(10, "Rogue Prestige 1", 6, 1, 8,
                90, 5, 1, 2, 5, 9, 8,
                12, 1.2, 0.2, 1, 0.2, 1, 0.8),
			new Hero(11, "Mage Prestige 1", 1, 9, 5,
                80, 1, 5, 2, 1, 7, 10,
                11, 0.2, 1.8, 0.6, 0, 0.8, 0.8),
			new Hero(12, "Berserker Prestige 1", 9, 1, 5,
                90, 5, 1, 2, 1, 10, 7,
                12, 1.8, 0.2, 0.6, 0, 1, 0.8),
			new Hero(13, "Cleric Prestige 1", 1, 8, 6,
                80, 1, 5, 2, 1, 7, 10,
                11, 0.2, 1.2, 1.2, 0, 0.8, 0.8),
			new Hero(14, "Assassin Prestige 1", 5, 1, 8,
                90, 5, 1, 2, 10, 9, 8,
                12, 1, 0.2, 1.2, 0.4, 1, 0.8),
			new Hero(15, "Paladin Prestige 1", 5, 5, 5,
                100, 3, 3, 2, 1, 8, 14,
                15, 0.6, 0.6, 0.6, 0, 0.8, 2),
			new Hero(16, "Dark Knight Prestige 1", 7, 7, 2,
                80, 3, 3, 2, 1, 9, 8,
                11, 0.9, 0.9, 0.7, 0, 0.8, 0.8),
            new Hero(17, "Bard Prestige 1", 5, 5, 5,
                60, 2, 2, 2, 1, 6, 6,
                13, 0.6, 0.6, 0.7, 0, 0.4, 0.4),
            ///////////////////////////////////////////////
            new Hero(18, "Warrior Prestige 2", 11, 1, 7,
                100, 5, 1, 2, 1, 14, 8,
                20, 1.4, 0.3, 0.9, 0, 2.5, 1.2),
            new Hero(19, "Rogue Prestige 2", 8, 1, 10,
                90, 5, 1, 2, 5, 9, 8,
                14, 1.8, 0.3, 1.5, 0.3, 1.5, 1.2),
            new Hero(20, "Mage Prestige 2", 1, 12, 6,
                80, 1, 5, 2, 1, 7, 10,
                14, 0.3, 2.8, 0.9, 0, 1.2, 1.2),
            new Hero(21, "Berserker Prestige 2", 12, 1, 7,
                90, 5, 1, 2, 1, 10, 7,
                16, 2.4, 0.3, 0.9, 0, 1.5, 1.2),
            new Hero(22, "Cleric Prestige 2", 1, 11, 8,
                80, 1, 5, 2, 1, 7, 10,
                14, 0.3, 1.8, 1.8, 0, 1.2, 1.2),
            new Hero(23, "Assassin Prestige 2", 7, 1, 11,
                90, 5, 1, 2, 10, 9, 8,
                16, 1.6, 0.3, 1.8, 0.7, 1.5, 1.2),
            new Hero(24, "Paladin Prestige 2", 8, 8, 7,
                100, 3, 3, 2, 1, 8, 14,
                20, 0.9, 0.9, 0.9, 0, 1.2, 3),
            new Hero(25, "Dark Knight Prestige 2", 10, 10, 4,
                80, 3, 3, 2, 1, 10, 9,
                15, 1.4, 1.4, 1, 0, 1.2, 1.2),
            new Hero(26, "Bard Prestige 2", 8, 8, 8,
                60, 2, 2, 2, 1, 6, 6,
                18, 0.9, 0.9, 1, 0, 1, 1),
		};

        public Monster[] Monsters = {
                                        //Tuvale Forest
                        // Name            lvl,     atk,    matk,   crit,   def,    mdef,   hp
			new Monster("Forest Gathering", 1,      0,      0,      0,      5,      5,      1),//
			new Monster("Moss Golem",       2,      15,     5,      5,      10,     5,      40),//
			new Monster("Forest Treant",    2,      5,      15,     5,      5,      10,     120),//
			new Monster("Grass Spider",     3,      5,      20,     10,     5,      10,     50),
			new Monster("Arachne",          3,      5,      25,     25,     5,      10,     65),//
			new Monster("Tuvale Viper",     4,      25,     5,      15,     10,     5,      60),
			new Monster("Venom",            4,      35,     10,     15,     10,     5,      70),
			new Monster("Wild Boar",        5,      20,     5,      5,      20,     5,      80),
			new Monster("Hogger",           5,      25,     5,      10,     30,     15,     100),
			new Monster("Goblin Footman",   6,      25,     5,      15,     25,     10,     100),
			new Monster("Grok The Mighty",  6,      35,     5,      20,     30,     10,     110),
			new Monster("Goblin Enchanter", 7,      5,      35,     10,     10,     15,     90),
			new Monster("Siru The Wise",    7,      5,      45,     10,     15,     25,     110),
			new Monster("Goblin Chieftain", 8,      40,     5,      20,     25,     15,     130),
			new Monster("Lord Gronok",      8,      50,     5,      25,     35,     15,     150),
			new Monster("Maexna",           9,      20,     40,     20,     20,     20,     250, maxPartyMembers: 2),
			new Monster("Queen Maexna",     9,      20,     55,     25,     20,     25,     280, maxPartyMembers: 2),
                                        //Yarsol Cove
			new Monster("Yarsol Gathering", 10,     0,      0,      0,      10,     10,     70),
			new Monster("Coral Giant",      11,     30,     5,      15,     20,     20,     150),
			new Monster("Water Willow",     11,     5,      30,     15,     20,     20,     150),
			new Monster("Yarsol Snapper",   12,     20,     5,      10,     40,     30,     240),
			new Monster("Wild Turtle",      12,     30,     5,      15,     50,     35,     260),
			new Monster("Murlok Priest",    13,     10,     40,     30,     20,     20,     180),
			new Monster("Murlok Tidecaller",13,     10,     50,     40,     20,     30,     200),
			new Monster("Sand Lizard",      14,     50,     5,      20,     30,     10,     200),
			new Monster("Leaping Lizzy",    14,     60,     5,      30,     40,     10,     220),
			new Monster("Murlok Spearman",  15,     50,     5,      30,     30,     10,     220),
			new Monster("Murlok Warleader", 15,     60,     5,      35,     35,     15,     240),
			new Monster("Murlok Assassin",  16,     55,     10,     50,     20,     10,     180),
			new Monster("Murlok Tidehunter",16,     65,     10,     55,     30,     15,     190),
			new Monster("Murlok Highpriest",17,     10,     70,     30,     20,     20,     220),
			new Monster("Prophet Nami",     17,     10,     80,     45,     25,     30,     250),
			new Monster("Basamus",          18,     110,    5,      30,     50,     30,     500, maxPartyMembers: 2),
			new Monster("Basamus Prime",    18,     130,    5,      30,     65,     35,     550, maxPartyMembers: 2),
                                        //Aldur Highlands
			new Monster("Aldur Gathering",  20,     0,      0,      0,      20,     20,     150),
			new Monster("Highland Titan",   21,     50,     5,      30,     40,     20,     250),
			new Monster("Aldur Guardian",   21,     5,      50,     30,     30,     30,     250),
			new Monster("Aldur Ram",        22,     65,     5,      40,     50,     20,     270),
			new Monster("Ceros",            22,     75,     5,      50,     60,     20,     290),
			new Monster("Highland Tunneler",23,     10,     75,     50,     40,     30,     250),
			new Monster("Terros",           23,     10,     85,     55,     50,     40,     280),
			new Monster("Gnoll Hunter",     24,     75,     5,      60,     55,     15,     300),
			new Monster("Reygar",           24,     90,     5,      60,     60,     20,     320),
			new Monster("Gnoll Shaman",     25,     5,      80,     50,     35,     35,     280),
			new Monster("Kaldar",           25,     5,      100,    60,     40,     40,     290),
			new Monster("Gnoll Overlord",   26,     150,    10,     70,     80,     40,     1000, maxPartyMembers: 3),
			new Monster("Drahgar",          26,     180,    10,     80,     100,    50,     1200, maxPartyMembers: 3),
			new Monster("Ares",             27,     250,    20,     60,     90,     70,     1000, maxPartyMembers: 3), //
			new Monster("Ares Prime",       27,     220,    30,     90,     130,    70,     1000, maxPartyMembers: 3),
                                        //Aldur Highlands
			new Monster("Vulkrum Gathering",30,     0,      0,      0,      25,     25,     200),
			new Monster("Dark Colossus",    31,     70,     5,      30,     50,     30,     320),
			new Monster("Haunted Harwood",  31,     5,      70,     30,     40,     40,     320),
			new Monster("Nightmare Scorpion",32,    60,     80,     50,     100,    100,    750, maxPartyMembers: 2),
			new Monster("Scorpinox",        32,     80,     110,    60,     110,    110,    900, maxPartyMembers: 2),
			new Monster("Night Beast",      33,     150,    20,     70,     120,    70,     900, maxPartyMembers: 2),
			new Monster("Night Stalker",    33,     180,    40,     70,     150,    100,    1200, maxPartyMembers: 2),
			new Monster("Undead Warrior",   34,     250,    20,     100,    180,    100,    2500, maxPartyMembers: 3),
			new Monster("Skeletor",         34,     270,    20,     100,    200,    100,    2800, maxPartyMembers: 3),
			new Monster("Undead Mage",      35,     20,     300,    90,     90,     150,    2000, maxPartyMembers: 3),
			new Monster("Altor",            35,     20,     320,    100,    100,    170,    2100, maxPartyMembers: 3),
			new Monster("Antares",          36,     220,    220,    120,    180,    150,    3500, maxPartyMembers: 5),
			new Monster("Serket",           36,     250,    250,    120,    200,    160,    3800, maxPartyMembers: 5),
			new Monster("Lich King",        37,     400,    50,     120,    250,    120,    4000, maxPartyMembers: 5),
			new Monster("Arthus",           37,     440,    60,     120,    280,    140,    4500, maxPartyMembers: 5),
                                        //Weekly Bosses
            new Monster("Genbu",            20,     100,    50,     30,     220,    180,    3200, maxPartyMembers: 5, first: true), //
			new Monster("Leviathan",        20,     130,    140,    50,     100,    120,    2100, maxPartyMembers: 5, first: true),
			new Monster("Kirin",            30,     380,    140,    90,     260,    140,    2900, maxPartyMembers: 5, first: true),
			new Monster("Oni",              40,     450,    150,    120,    360,    200,    5400, maxPartyMembers: 6, first: true),
			new Monster("Hel",              40,     200,    540,    120,    180,    280,    4200, maxPartyMembers: 6, first: true),
		};

        public Skill[] Skills = {
            /*passives*/
            new Skill("Might", false, 0, new int[] {0,1,3,9,10,12,18,19,21}, desc:"Passively increase Atk by 10%", raisepatk:1.1),
            new Skill("Vitality", false, 0, new int[] {0,6,9,15,18,24}, desc:"Passively increase Def by 12% and Atk by 6%", raisepatk:1.06, raisepdef: 1.12),
            new Skill("Juggernaut", false, 0, new int[] {0,6,8,9,15,17,18,24,26}, desc:"Passively increase Hp by 25%", raisehp:1.25),
            new Skill("Keen Eye", false, 0, new int[] {1,5,10,14,19,23}, desc:"Passively increase Acc by 10%", raiseacc:1.1),
	        new Skill("Critical Strike", false, 0, new int[] {1,3,5,10,12,14,19,21,23}, desc:"Passively increase Crit Dmg by 35%", raisecritdmg:1.35),
            new Skill("Intellect", false, 0, new int[] {2,4,11,13,20,22}, desc:"Passively increase Matk by 10%", raisematk:1.1),
            new Skill("Wisdom", false, 0, new int[] {2,4,7,8,11,13,16,17,20,22,25,26}, desc:"Passively increase Ap by 2"), // MISSING
            new Skill("Mind", false, 0, new int[] {2,4,6,11,13,15,20,22,24}, desc:"Passively increase Mdef & Acc by 10%", raisemdef:1.1, raiseacc:1.1),
            new Skill("Critical Eye", false, 0, new int[] {3,5,12,14,21,23}, desc:"Passively increase Crit Chance by 12%", raisecritchc:1.12),
            new Skill("Dark Arts", false, 0, new int[] {7,16,25}, desc:"Passively increase Atk & Matk by 9%", raisepatk:1.09, raisematk:1.09),
            new Skill("Dark Precision", false, 0, new int[] {7,16,25}, desc:"Passively increase Acc by 50 and Crit by 10", plusacc:50, pluscritchc:10),
            new Skill("Consolidate", false, 0, new int[] {8,17,26}, desc:"Passively increase Def and Mdef by 5%", raisepdef:1.05, raisemdef:1.05),
            /*warrior*/
            new Skill("Basic", true, 0, new int[] {}, desc:"Deal 1x Atk & 1x Matk", dealpatk:1, dealmatk:1),
            new Skill("Slash", true, 4, new int[]{0,3,9,12,18,21}, desc:"Deal 1.6x Atk", dealpatk:1.6),
            new Skill("Shield Slam", true, 5, new int[] {0,9,18}, desc:"Deal 1.4x Def & Gain Def↑40% for 2 Turns", dealdef:1.4, buffdef:1.4, duration:2),
            new Skill("Block", true, 7, new int[] {0,9,18}, desc:"Block the next Physical Attack", ignoredmg:true, duration:1),
            new Skill("Slash II", true, 7, new int[] {0,3,9,12,18,21}, desc:"Deal 2.2x Atk", dealpatk:2.2),
            new Skill("Unbreakable", true, 4, new int[] {0,9,18}, desc:"Remove all Debuffs"), // MISSING
            new Skill("Shield Slam II", true, 8, new int[] {0,9,18}, desc:"Deal 2.3x Def & Gain Def↑60% for 3 Turns", dealdef:2.3, buffdef:1.6, duration:3),
            new Skill("Taunt", true, 8, new int[] {0,9,18}, desc:"Next enemy attack only hits hero"), // MISSING
            /*rogue*/
            new Skill("Kidney Shot", true, 4, new int[] {1,5,10,14,19,23}, desc:"Deal 1.6x Acc as Physical Dmg", dealacc:1.6),
            new Skill("Sunder", true, 6, new int[] {1,10,19}, desc:"Deal 1.2x Atk & Give Def↓25% for 2 Turns", dealpatk:1.2), // MISSING
            new Skill("Cheap Shot", true, 6, new int[] {1,10,19}, desc:"Deal 1.1x Atk as True Dmg (Ignore Def)", dealtrue:1.1),
            new Skill("Evade", true, 8, new int[] {1,5,10,14,19,23}, desc:"Evade the next Attack", ignoredmg:true, duration:1),
            new Skill("Kidney Shot II", true, 7, new int[] {1,10,19}, desc:"Deal 2.2x Acc as Physical Dmg", dealacc:2.2),
            new Skill("Cheap Shot II", true, 9, new int[] {1,10,19}, desc:"Deal 1.6x Atk as True Dmg (Ignore Def)", dealtrue:1.6),
            new Skill("Sunder II", true, 9, new int[] {1,10,19}, desc:"Deal 1.8x Atk & Give Def↓35% for 3 Turns", dealpatk:1.8),  // MISSING
            /*mage*/
            new Skill("Mind Blast", true, 4, new int[] {2,4,11,13,20,22}, desc:"Deal 1.6x Matk", dealmatk:1.6),
            new Skill("Magic Missile", true, 6, new int[] {2,11,20}, desc:"Deal 1.4x Matk & Gain Matk↑25% for 2 Turns", dealmatk:1.4, raisematk:1.25, duration:2),
            new Skill("Mind Blast II", true, 7, new int[] {2,4,11,13,20,22}, desc:"Deal 2.2x Matk", dealmatk:2.2),
            new Skill("Mana Shield", true, 5, new int[] {2,11,20}, desc:"Reflect 0.6x Matk on next attack received"), // MISSING
            new Skill("Silence", true, 8, new int[] {2,11,20}, desc:"Remove all Buffs from the Enemy"), // MISSING
            new Skill("Magic Missile II", true, 9, new int[] {2,11,20}, desc:"Deal 2x Matk & Gain Matk↑25% for 3 Turns", dealmatk:2, raisematk:1.25, duration:3),
            new Skill("Mana Shield II", true, 8, new int[] {2,11,20}, desc:"Reflect 1.2x Matk on next attack received"), // MISSING
            /*berserker*/
            new Skill("Enrage", true, 3, new int[] {3,12,21}, desc:"Gain Atk↑60% for 3 Turns", raisepatk:1.6, duration:3),
            new Skill("Vicious Strike", true, 6, new int[] {3,12,21}, desc:"Deal 1.4x Atk & Gain Atk↑25% for 2 Turns", raisepatk:1.25, dealpatk:1.4, duration:2),
            new Skill("Blind Fury", true, 3, new int[] {3,12,21}, desc:"Gain Crit↑60% & Acc ↓25% for 4 Turns"), // MISSING
            new Skill("Vicious Strike II", true, 9, new int[] {3,12,21}, desc:"Deal 2x Atk & Gain Atk↑25% for 3 Turns", dealpatk:2, raisepatk:1.25, duration:3),
            new Skill("Berserk Smash", true, 7, new int[]{3,12,21}, desc:"Deal 1.8x Atk & Gain Atk↑15% on Crit (stacks)", dealpatk:1.8, raisepatk:1.15), // MISSING
            /*cleric*/
            new Skill("Divine Smite", true, 6, new int[] {4,13,22}, desc:"Deal 1.5xMatk&Acc. Party ↑15%Matk&Acc (3 turns)", dealmatk:1.5,raiseacc:1.15, duration:3), // MISSING
            new Skill("Lesser Heal", true, 7, new int[] {4,13,22}, desc:"Heal the target in front of you for .8x Matk"), // MISSING
            new Skill("Cleanse", true, 9, new int[] {4,13,22}, desc:"Remove all Debuffs on whole party"), // MISSING
            new Skill("Greater Heal", true, 9, new int[] {4,13,22}, desc:"Heal the party for .25x Matk"), // MISSING
            new Skill("Revive", true, 10, new int[] {4,13,22}, desc:"Revive a fallen party member with 50% hp"), // MISSING
            /*assassin*/
            new Skill("Stab", true, 5, new int[] {5,14,23}, desc:"Deal 1.6x Atk with Crit Dmg +50%"), // MISSING
            new Skill("Puncture", true, 6, new int[] {5,14,23}, desc:"Deal 1.1x Acc as True Dmg"), // MISSING
            new Skill("Stab II", true, 8, new int[] {5,14,23}, desc:"Deal 2.3x Atk with Crit Dmg +100%"), // MISSING
            new Skill("Puncture II", true, 9, new int[] {5,14,23}, desc:"Deal 1.7x Acc as True Dmg"), // MISSING
            new Skill("Ambush", true, 12, new int[] {5,14,23}, desc:"Deal 3x Atk&Acc. Enemy ↓50% Atk for 1 turn", dealacc:3, dealpatk:3), // MISSING
            /*paladin*/
            new Skill("Divine Strike", true, 4, new int[] {6,15,24}, desc:"Deal 1.4x Atk & Heal for .2x Matk", dealpatk:1.4), // MISSING
            new Skill("Templar Shield",true, 6, new int[] {6,15,24}, desc:"Deal 1.5x Atk & 2x Matk", dealpatk:1.5, dealmatk:2),
            new Skill("Shield", true, 7, new int[] {6,15,24}, desc:"Block the next Magical Attack"), // MISSING
            new Skill("Holy Blessing", true, 4, new int[] {6,15,24}, desc:"Give party Atk↑15% & Mdef↑50% for 5 Turns", raisepatk:1.15, raisemdef:1.5, duration:5),
            new Skill("Unbreakable", true, 4, new int[] {6,15,24}, desc:"Remove all Debuffs"), // MISSING
            new Skill("Divine Strike II", true, 8, new int[] {6,15,24}, desc:"Deal 1.8x Atk & Heal for .5x Matk"), // MISSING
            new Skill("Holy Shield", true, 9, new int[] {6,15,24}, desc:"Block next Magical Attack for whole party"), // MISSING
            /*darkknight*/
            new Skill("Unholy Slash", true, 4, new int[] {7,16,25}, desc:"Deal 1.5x Atk & Matk Lifesteal 8%", dealpatk:1.5, dealmatk:1.5), // MISSING
            new Skill("Slow", true, 4, new int[] {7,16,25}, desc:"Deal .6x Matk and Give Eva↓80% for 3 Turns", dealmatk:0.6), // MISSING
            new Skill("Terrify", true, 7, new int[] {7,16,25}, desc:"Deal 1.4x Atk&Matk Give Mdef↓30% for 2 Turns", dealpatk:1.4, dealmatk:1.4), // MISSING
            new Skill("Overwhelm", true, 3, new int[] {7,16,25}, desc:"Party gain Atk↑25% & Matk↑25% for 3 Turns"), // MISSING
            new Skill("Crypt Poison", true, 6, new int[] {7,16,25}, desc:"Deal 1x Atk & 1x Matk for 3 Turns"), // MISSING
            new Skill("Unholy Slash II", true, 6, new int[] {7,16,25}, desc:"Deal 2x Atk & Matk Lifesteal 10%"), // MISSING
            new Skill("Twilight Strike", true, 7, new int[] {7,16,25}, desc:"Deal 1.1x Atk & 1.1x Matk as True Dmg"), // MISSING
            /*bard*/
            new Skill("Serenade", true, 4, new int[] {8,17,26}, desc:"Gain Def↓100% and Give Atk↓50% for 1 Turn"), // MISSING
            new Skill("Song of Courage", true, 10, new int[] {8,17,26}, desc:"Give Party↑8% Matk & Atk for 10 turns(stacks)", duration:10), // MISSING
            new Skill("Master Decoy", true, 5, new int[] {8,17,26}, desc:"1 Turn Def & Mdef ↓50% Heal Party for 50% Dmg"), // MISSING
            new Skill("Poem of Focus", true, 6, new int[] {8,17,26}, desc:"This turn all crits do 2.5x more dmg"), // MISSING
            new Skill("Song of Defense", true, 9, new int[] {8,17,26}, desc:"Give Party 40% reflect on next attack received"), // MISSING
            new Skill("Peaceful Respite", true, 6, new int[] {8,17,26}, desc:"Party and Enemy ↓50% Atk & Matk for 1 turn"), // MISSING
            new Skill("Double Image", true, 7, new int[] {8,17,26}, desc:"50% chance to skip next enemy attack"), // MISSING
            new Skill("Recharge", true, -1, new int[] {8,17,26}, desc:"Skips turn, adds 1 AP"), // MISSING
            // Monsterskills
        };

        public Item[] Items = {
            new Item("Worn Weapon", 0, ItemSlot.Weapon),
            new Item("Worn Helm", 0, ItemSlot.Helm),
            new Item("Worn Chest", 0, ItemSlot.Chest),
            new Item("Worn Gloves", 0, ItemSlot.Gloves),
            new Item("Worn Boots", 0, ItemSlot.Boots),
            new Item("Worn Trinket", 0, ItemSlot.Trinket),
        };
    }
}
