using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SummerSelfDirectedProjectConsoleRPG.ElementalSpells;
using static SummerSelfDirectedProjectConsoleRPG.HealingSpells;
using static SummerSelfDirectedProjectConsoleRPG.HolySpells;
using static SummerSelfDirectedProjectConsoleRPG.ArcaneSpells;
using static SummerSelfDirectedProjectConsoleRPG.IllusionSpells;
using static SummerSelfDirectedProjectConsoleRPG.NatureSpells;
using static SummerSelfDirectedProjectConsoleRPG.Spells;

namespace SummerSelfDirectedProjectConsoleRPG
{
    internal class IllusionSpells : Spells
    {
        public int Diameter { get; set; }

        public int Targets { get; set; }

        //public int SpellTargetX { get; set; }  
        //public int SpellTargetY { get; set; }  

        //public (int min, int max) SpellArea_x {  get; set; }
        //public (int min, int max) SpellArea_y { get; set; } 

        public IllusionSpells(string type, string name, int level, int castingTime, int failurePercent, int DmgMultiplier, int diceType, int spellAtk, int manaCost, char targSymbol, ConsoleColor targColor, int diameter, int _targets) //, int spellTargetX, int spellTargetY, (int,int) spellArea_x, (int,int) spellArea_y)
        : base(type, name, level, castingTime, failurePercent, DmgMultiplier, diceType, spellAtk, manaCost, targSymbol, targColor)

        {
            Diameter = diameter;
            Targets = _targets;
            //SpellTargetX = spellTargetX;
            //SpellTargetY = spellTargetY;
            //SpellArea_x = spellArea_x;
            //SpellArea_y = spellArea_y;
        }

        public static IllusionSpells Distraction => new IllusionSpells("Illusion", "Distraction", 1, 1, 5, 1, 2, 0, 1, '@', ConsoleColor.Magenta, 1, 1); //, spellTargetX, spellTargetY, ((spellTargetX - 0), (spellTargetX + 0)), ((spellTargetY - 0), (spellTargetY + 0)));
        public static IllusionSpells Darkness => new IllusionSpells("Illusion", "Darkness", 1, 1, 5, 1, 4, 1, 2, '@', ConsoleColor.Magenta, 1, 1); //, spellTargetX, spellTargetY, ((spellTargetX - 0), (spellTargetX + 0)), ((spellTargetY - 0), (spellTargetY + 0)));
        public static IllusionSpells FlashingLights => new IllusionSpells("Illusion", "Flashing Lights", 1, 1, 15, 2, 6, 2, 4, '@', ConsoleColor.Magenta, 1, 1); //, spellTargetX, spellTargetY, ((spellTargetX - 0), (spellTargetX + 0)), ((spellTargetY - 0), (spellTargetY + 0)));
        public static IllusionSpells Unlock => new IllusionSpells("Illusion", "Unlock", 1, 2, 20, 4, 8, 3, 8, '@', ConsoleColor.Magenta, 5, 25); //, spellTargetX, spellTargetY, ((spellTargetX - 2), (spellTargetX + 2)), ((spellTargetY - 2),( spellTargetY + 2)));
        public static IllusionSpells Doppleganer => new IllusionSpells("Illusion", "Doppleganer", 1, 4, 25, 8, 10, 4, 16, '@', ConsoleColor.Magenta, 9, 81); //, spellTargetX, spellTargetY, (spellTargetX - 4, spellTargetX + 4), (spellTargetY - 4, spellTargetY + 4));
        public static IllusionSpells GhostLegion => new IllusionSpells("Illusion", "Ghost Legion", 1, 8, 35, 16, 12, 5, 32, '@', ConsoleColor.Magenta, 21, 441); //, spellTargetX, spellTargetY, (spellTargetX - 10, spellTargetX + 10), (spellTargetY - 10, spellTargetY + 10));

    }
}
