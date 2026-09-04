using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
   public class Spells
    {
        public string _type { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int CastingTime { get; set; }
        public int FailurePercent { get; set; }
        public int DamageMultiplier{ get; set; }
        public int DiceType { get; set; }
        public int SpellAttackBonus { get; set; }
        public int ManaCost { get; set; }

        //0= no magic, 1= Elemental, 2= Arcane, 3= Nature, 4= Holy, 5= Healing, 6= Illusion

        public ConsoleColor _targColor;
        public char _targSymbol { get; protected set; }

        public Spells(string type, string name, int level, int castingTime, int failurePercent, int DmgMultiplier, int diceType, int spellAtk, int manaCost, char targSymbol, ConsoleColor targColor)
        {
            _type = type;
            Name = name;

            Level = level;
            CastingTime = castingTime;
            FailurePercent = failurePercent;

            DamageMultiplier = DmgMultiplier;
            DiceType = diceType;
            SpellAttackBonus = spellAtk;
            ManaCost = manaCost;
            
            _targSymbol = targSymbol;
            _targColor = targColor;



        }
    }

}
