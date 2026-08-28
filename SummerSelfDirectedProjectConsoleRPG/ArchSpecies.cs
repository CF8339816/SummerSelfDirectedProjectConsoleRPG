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
    public class ArchSpecies

    {
        public string Vision { get; }
        public int HpBonusSpecies { get; }
        public string BonusSpellsSpecies1 { get; }
        public string BonusSpellsSpecies2 { get; }
        public int ACbonusSpecies { get; }
      


        private ArchSpecies(string vision, int HpBspecies, string bonusSpellsSpecies1, string bonusSpellsSpecies2, int acBonusSpecies)
        {

           Vision = vision;
            HpBonusSpecies = HpBspecies;
            BonusSpellsSpecies1 = bonusSpellsSpecies1;
            BonusSpellsSpecies2 = bonusSpellsSpecies2;
            ACbonusSpecies = acBonusSpecies;


        }

        public static ArchSpecies DragonKin => new ArchSpecies("standard", 5, "DragonScale Armor", "Breath of the Dragon",  3);
        public static ArchSpecies DaemonKyne=> new ArchSpecies("lowLight", 5,  "Hellfire", "Polymorph", 2);
        public static ArchSpecies Dwarf => new ArchSpecies("Dark", 10, "Escavate",  "Brew",  4);
        public static ArchSpecies Elf => new ArchSpecies("Keen", -2,  "Fay Illuminte", "N/A", -1);
        public static ArchSpecies Human => new ArchSpecies("Standard", 0, "N/A", "N/A", 0);
        public static ArchSpecies SmallFolk => new ArchSpecies("Keen", -4, "N/A", "N/A",  -2);
        public static ArchSpecies Orc => new ArchSpecies("Standard", 0, "N/A", "N/A", 0);
        public static ArchSpecies Goblin => new ArchSpecies("Standard", 0, "N/A", "N/A", 0);
        public static ArchSpecies HobGoblin => new ArchSpecies("Standard", 0, "N/A", "N/A", 0);
        public static ArchSpecies Gnoll => new ArchSpecies("Standard", 0, "N/A", "N/A", 0);


    }
}

