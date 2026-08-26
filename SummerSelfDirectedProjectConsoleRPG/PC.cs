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
        //public string Name { get; }

        public static int plXP = 0;
        public static int plLevel = 0;


        public int ArmorClass { get; }
        public int MaxHP { get; }


        public ArchType ArcJob { get; }
        public ArchSpecies ArcSpecies { get; } 
      

     

        public PC(string type, string name, int strength, int speed, int dex, int baseAC, int baseHp, int baseAtk, int baseMana, char symbol, ConsoleColor color, ArchType arcJob, ArchSpecies arcSpecies, int maxHP, int maxAC, int level, int XP)


        {
            //Name = name;
            ArcJob = arcJob;
            ArcSpecies = arcSpecies;
            ArmorClass = maxAC;
            MaxHP = maxHP;
            plXP = XP;
            plLevel = level;
        }

    }
}
