using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SummerSelfDirectedProjectConsoleRPG.ArchSpecies;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;
using static SummerSelfDirectedProjectConsoleRPG.PC;
using static SummerSelfDirectedProjectConsoleRPG.Program;


namespace SummerSelfDirectedProjectConsoleRPG
{
    public class ArchType
    {

        public string DefaultName { get; }

        public string JobTitle { get; }
       
        public ArchSpecies DefaultSpecies { get; }
        public int HpBonusPerLevel { get; }
        public int AtHp { get; }
        public string Species { get; }
        public int MaxSpellLevel1 { get; }
        public int MaxSpellLevel2 { get; }
        public string MagicType1 { get; }
        public string MagicType2 { get; }
        public int XPtoLevelMultiplier { get; }
        public string ArmorType1 { get; set; }
        public string ArmorType2 { get; set; }
        public string WeaponType1 { get; set; }
        public int ArmorBonus { get; }
        public int AttackBonus { get; }
        public int ManaBonus { get; }

        private ArchType(string dName, string jobTitle, int HpBPL, int atHp, int JobAtkBonus,int JobManaBonus, ArchSpecies defSpecies, 
            int maxSL1, int maxSL2, string magType1, string magType2, int xp2LMulti, string armorType1, string armorType2, string weaponType1, int ArBonus)
        {

            DefaultName = dName;          
            JobTitle = jobTitle;

            HpBonusPerLevel = HpBPL;
            AtHp = atHp;
            DefaultSpecies = defSpecies;
            MaxSpellLevel1 = maxSL1;
            MaxSpellLevel2 = maxSL2;
            MagicType1 = magType1;
            MagicType2 = magType2;
            XPtoLevelMultiplier = xp2LMulti;


            ArmorType1 = armorType1;
            ArmorType2 = armorType2;
            WeaponType1 = weaponType1;


        ArmorBonus = ArBonus;
            AttackBonus = JobAtkBonus;
            ManaBonus = JobManaBonus;

        }
        // player classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, armorType1, armorType2, weaponType1, ArBonus)
        public static ArchType Paladin => new ArchType("Medrin", "Paladin", 5, 50, 5,3, DragonKin, 3, 0, "Holy", "N/A", 13, "Plate", "N/A", "Melee", 5);
        public static ArchType Bard => new ArchType("Tessa", "Bard", 2, 35, 2,2, DaemonKyne, 3, 6, "Healing", "Illusion", 11, "Leather", "N/A", "Melee", 2);
        public static ArchType Cleric => new ArchType("Fray", "Cleric", 4, 40, 5, 5, Dwarf, 6, 6, "Holy", "Healing", 13, "ChainMail", "Shield", "Melee", 4);
        public static ArchType Sorcerer => new ArchType("Garth", "Sorcerer", 1, 10, 1, 8, Human, 6, 6, "Arcane ", "Elemental", 12, "Cloth", "N/A", "Melee", 1);
        public static ArchType Ranger => new ArchType("Nae'O'mii", "Ranger", 3, 30, 4, 2, Elf, 3, 5, "Nature", "N/A", 10, "Leather", "Buckler", "Ranged", 3);
        public static ArchType Rogue => new ArchType("Kayleigh", "Rogue", 2, 20, 3, 1, SmallFolk, 4, 0, "Illusion", "N/A", 12, "leather", "N/A", "Melee", 2);


        //Enemy classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, Armor, ArBonus)
         public static ArchType Peon => new ArchType("", "Peon", 3, 30, 4, 2, Goblin, 3, 5, "N/A", "N/A", 10, "Cloth", "N/A", "Melee", 1);
        public static ArchType Skirmisher => new ArchType("", "Skirmisher", 4, 40, 5, 5, Goblin, 6, 6, "N/A", "N/A", 13, "Leather", "Shield", "Melee", 2);
        public static ArchType Warboss => new ArchType("", "WarBoss", 1, 10, 1, 8, HobGoblin, 6, 6, "N/A ", "N/A", 12, "Plate", "N/A", "Melee", 3);
        public static ArchType Champion => new ArchType("", "Champion", 3, 30, 4, 2, Gnoll, 3, 5, "Arcane", "N/A", 10, "Chain", "Shield", "Melee", 3);
        public static ArchType Shaman => new ArchType("", "Shaman", 2, 20, 3, 1, Gnoll, 4, 0, "Nature", "Elemental", 12, "Cloth", "N/A", "Melee", 2);
        public static ArchType ClanChief => new ArchType("", "Clan Chief", 2, 20, 3, 1, Orc, 4, 0, "Arcane", "Healing", 12, "Plate", "Shield", "Melee", 4);

        // NPC Classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, Armor, ArBonus)

        public static ArchType Peasant => new ArchType("", "Peasant", 4, 40, 5, 5, Goblin, 6, 6, "N/A", "N/A", 13, "Cloth", "N/A", "Melee", 4);
        public static ArchType Merchant => new ArchType("", "Merchant", 1, 10, 1, 8, HobGoblin, 6, 6, "N/A ", "N/A", 12, "Cloth", "N/A", "Melee", 1);
        public static ArchType Noble => new ArchType("", "Nobel", 3, 30, 4, 2, Goblin, 3, 5, "N/A", "N/A", 10, "Cloth", "N/A", "Melee", 3);
        public static ArchType Guard => new ArchType("", "Guard", 2, 20, 3, 1, Gnoll, 4, 0, "N/A", "N/A", 12, "Leather", "Shield", "Ranged", 2);
        public static ArchType Sheriff => new ArchType("", "Sheriff", 3, 30, 4, 2, Gnoll, 3, 5, "Illusion", "N/A", 10, "Chain", " Shield", "Melee", 3);
        public static ArchType Knight => new ArchType("", "Knight", 2, 20, 3, 1, Orc, 4, 0, "Arcane", "Healing", 12, "Plate", "Shield", "Melee", 2);

    }
}

