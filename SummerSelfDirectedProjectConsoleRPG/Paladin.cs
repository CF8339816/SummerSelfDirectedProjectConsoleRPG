using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class Paladin
    {

        private string DefaultName = "Medrin";
        public int HpBonusPerLevel = 5;
        public int AtHp = 50;
        public string species = " DragonBorn";

        public int MaxSpellLevel1 = 3;
        public int MaxSpellLevel2 = 0;
        public string MagicType1 = "Holy";
        public string MagicType2 = null;


        public int XPtoLevelMultiplier = 12;
        public string ArmorType = "Plate";
        public int ArmorBonus = +5;
    }
}

