using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SummerSelfDirectedProjectConsoleRPG.FireSpells;
using static SummerSelfDirectedProjectConsoleRPG.HealingSpells;
using static SummerSelfDirectedProjectConsoleRPG.HolySpells;
using static SummerSelfDirectedProjectConsoleRPG.IceSpells;
using static SummerSelfDirectedProjectConsoleRPG.IllusionSpells;
using static SummerSelfDirectedProjectConsoleRPG.NatureSpells;
using static SummerSelfDirectedProjectConsoleRPG.Spells;


namespace SummerSelfDirectedProjectConsoleRPG
{
    public class FireSpells : Spells
    {
        public int Diameter { get; set; }
        public int Targets { get; set; }


        public FireSpells(string type, string name, int level, int castingTime, int failurePercent, int DmgMultiplier, int diceType, int spellAtk, int manaCost, int diameter, int _targets)
        : base(type, name, level, castingTime, failurePercent, DmgMultiplier, diceType, spellAtk, manaCost)

        {
        Diameter = diameter;
        Targets = _targets;
        }

        public static FireSpells Sparks => new FireSpells("fire", "Sparks", 1, 1, 5, 1, 2, 0, 1, 1,  1);
        public static FireSpells CampFire => new FireSpells("fire", "Camp Fire",1, 1, 5, 1, 4, 1, 2, 1,  1);
        public static FireSpells Immolate => new FireSpells("fire", "Immolate", 1, 1, 15, 2, 6, 2, 4, 1,1);
        public static FireSpells Fireball => new FireSpells("fire", "Fireball", 1, 2, 20, 4, 8, 3, 8, 4, 4);
        public static FireSpells RainOfFire => new FireSpells("fire", "Rain Of Fire", 1, 4, 25, 8, 10, 4, 16, 8,16);
        public static FireSpells MeteorStrike => new FireSpells("fire", "Meteor Strike", 1, 8, 35, 16, 12, 5, 32, 20,  64);

    }
}

