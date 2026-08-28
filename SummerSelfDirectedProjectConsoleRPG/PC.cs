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

    public class PC : Character
    {

       public int PcHp = 100;
        //public string Name { get; }
        public int plXP = 0;
        public int plLevel = 0;


        public int ArmorClass { get; }
        public int MaxHP { get; }


        public ArchType ArcJob = HUD.jobType;
        public ArchSpecies ArcSpecies = HUD.SpeciesChoice;



        public PC(string _type, string name, int strength, int speed, int dex, int baseAC, int baseHp, int baseAtk, int baseMana, char symbol, ConsoleColor color, ArchType arcJob, ArchSpecies arcSpecies, int maxHP, int maxAC, int level, int XP)
           : base("PC", name, strength, speed, dex, baseAC, baseHp, baseAtk, baseMana, symbol, color)

        //public PC(string type, string name, int strength, int speed, int dex, int baseAC, int baseHp, int baseAtk, int baseMana, char symbol, ConsoleColor color, ArchType arcJob, ArchSpecies arcSpecies, int maxHP, int maxAC, int level, int XP):
        //    base("PC", HUD.nameChoice, 11,11,10,7,2,12, symbol= '&', color = ConsoleColor.Blue)//, arcJob, arcSpecies, Program.PlayerHp, Program.PlayerAC, 0,0)


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
