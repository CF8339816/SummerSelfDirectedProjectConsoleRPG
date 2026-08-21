using SummerSelfDirectedProjectConsoleRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class ArchType
    {

        public string DefaultName { get; }
        public int HpBonusPerLevel { get; }
        public int AtHp { get; }
        public string Species { get; }

        public int MaxSpellLevel1 { get; }
        public int MaxSpellLevel2 { get; }
        public string MagicType1 { get; }
        public string MagicType2 { get; }

        public int XPtoLevelMultiplier { get; }
        public string ArmorType { get; }
        public int ArmorBonus { get; }



        private ArchType(string name, int HpBPL, int atHp, string species, int maxSL1, int maxSL2, string magType1, string magType2, int xp2LMulti, string Armor, int ArBonus)
        {

            DefaultName = name;
            HpBonusPerLevel = HpBPL;
            AtHp = atHp;
            Species = species;
            MaxSpellLevel1 = maxSL1;
            MaxSpellLevel2 = maxSL2;
            MagicType1 = magType1;
            MagicType2 = magType2;
            XPtoLevelMultiplier = xp2LMulti;
            ArmorType = Armor;
            ArmorBonus = ArBonus;




        }



    }
}








