using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class Cleric
    {

        private string DefaultName = "Fray";
        public int HpBonusPerLevel = 4;
         public int AtHp = 40;
        public int MaxSpellLevel1 = 6;
        public int MaxSpellLevel2 = 6;
        public string MagicType1 = "Healing";
        public string MagicType2 = "Holy";

        public int XPtoLevelMultiplier = 11;
        public string ArmorType = "Chain and Sheild";
        public int ArmorBonus = +4;
    }
}