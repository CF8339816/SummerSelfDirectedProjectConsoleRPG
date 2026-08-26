using SummerSelfDirectedProjectConsoleRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.ArchSpecies;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;
//using static SummerSelfDirectedProjectConsoleRPG.PC;

namespace SummerSelfDirectedProjectConsoleRPG

{ 

    public class PC : Character
    {

        private const int PcHp = 100;
        public string Name { get; }

        public static int plXP = 0;
        public static int plLevel = 0;

        public int MaxHP { get; }

        public int ArmorClass { get; }
        public ArchType ArcJob { get; }

        public static string nameUsed;

        public PC(string name, ArchType arcJob, int maxHP, int maxAC, int speed, int dex, int ac, string magic, int strength, char symbol, ConsoleColor color, int attack,
            int mana, string nameUsed, string arcType, int plHpPerLevBonus, int level, int armorValue, int spellsPerLevel)


        {
            Name = name;
            ArcJob = arcJob;
            ArmorClass = maxAC;
            MaxHP = maxHP;
        }

    }

}