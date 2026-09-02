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
using static SummerSelfDirectedProjectConsoleRPG.ElementalSpells;
using static SummerSelfDirectedProjectConsoleRPG.ArcaneSpells;
using static SummerSelfDirectedProjectConsoleRPG.HolySpells;
using static SummerSelfDirectedProjectConsoleRPG.HealingSpells;
using static SummerSelfDirectedProjectConsoleRPG.NatureSpells;
using static SummerSelfDirectedProjectConsoleRPG.IllusionSpells;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class Enemy : Character
    {

        public int EnHp = 100;
                   
        public int EnLevel = 0;

        public int EnArmorClass { get; }
        public int EnMaxHP { get; }

        public ArchType EnArcJob;
        public ArchSpecies EnArcSpecies;



        public Enemy(string _type, string name, int strength, int speed, int dex, int baseAC, int baseHp, int baseAtk, int baseMana, char symbol, ConsoleColor color, ArchType enArcJob, ArchSpecies enArcSpecies, int maxEnHP, int maxEnAC, int levelEn)
            : base("PC", name, strength, speed, dex, baseAC, baseHp, baseAtk, baseMana, symbol, color)



        {

            EnArcJob = enArcJob;
            EnArcSpecies = enArcSpecies;
            EnArmorClass = maxEnAC;
            EnMaxHP = maxEnHP;
               
            EnLevel = levelEn;
        }

    }
 }

