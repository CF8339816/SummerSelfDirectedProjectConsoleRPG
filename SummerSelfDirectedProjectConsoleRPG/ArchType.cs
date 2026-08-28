using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.ArchSpecies;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;
using static SummerSelfDirectedProjectConsoleRPG.PC;
using static SummerSelfDirectedProjectConsoleRPG.Program;


namespace SummerSelfDirectedProjectConsoleRPG
{
    public class ArchType
    {

        public string DefaultName { get; }
        public string DefaultSpecies { get; }
        public int HpBonusPerLevel { get; }
        public int AtHp { get; }
        public string Species { get; }

        public int MaxSpellLevel1 { get; }
        public int MaxSpellLevel2 { get; }
        public string MagicType1 { get; }
        public string MagicType2 { get; }

        public int XPtoLevelMultiplier { get; }
        public string ArmorType { get; }
        public int ArmorBonus { get; }



        private ArchType(string dName, int HpBPL, int atHp, string defSpecies, int maxSL1, int maxSL2, string magType1, string magType2, int xp2LMulti, string Armor, int ArBonus)
        {

            DefaultName = dName;
            HpBonusPerLevel = HpBPL;
            AtHp = atHp;
            DefaultSpecies = defSpecies;
            MaxSpellLevel1 = maxSL1;
            MaxSpellLevel2 = maxSL2;
            MagicType1 = magType1;
            MagicType2 = magType2;
            XPtoLevelMultiplier = xp2LMulti;
            ArmorType = Armor;
            ArmorBonus = ArBonus;




        }

        public static ArchType Paladin => new ArchType("Medrin", 5, 50, "DragonKin", 3, 0, "Holy", "N/A", 13, "Plate", 5);
        public static ArchType Bard => new ArchType("Tessa", 2, 35, "Daemonkyne", 3, 6, "Holy", "Illusion", 11, "Leather", 2);
        public static ArchType Cleric => new ArchType("Fray", 4, 40, "Dwarf", 6, 6, "Holy", "Healing", 13, "ChainMail & Shield", 4);
        public static ArchType Sorcerer => new ArchType("Garth", 1, 10, "Human", 6, 6, "Arcane ", "Elemental", 12, "Cloth", 1);
        public static ArchType Ranger => new ArchType("Nae'O'mii", 3, 30, "Elf", 3, 5, "Nature", "N/A", 10, "Leather & Buckler", 3);
        public static ArchType Rogue => new ArchType("Kayleigh", 2, 20, "SmallFolk", 4, 0, "Illusion", "N/A", 12, "leather", 2);


    }
}

