using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SummerSelfDirectedProjectConsoleRPG.ArchSpecies;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;
using static SummerSelfDirectedProjectConsoleRPG.PC;
using static SummerSelfDirectedProjectConsoleRPG.Program;
using static SummerSelfDirectedProjectConsoleRPG.Weapon;
using static SummerSelfDirectedProjectConsoleRPG.Armor;
using static SummerSelfDirectedProjectConsoleRPG.EquipmentManager;



namespace SummerSelfDirectedProjectConsoleRPG
{
    public class ArchType
    {

        public string DefaultName { get; }

        public string JobTitle { get; }
       
        public ArchSpecies DefaultSpecies { get; }
        public int HpBonusPerLevel { get; }
        public int AtHp { get; }
        public string Species { get; }
        public int MaxSpellLevel1 { get; }
        public int MaxSpellLevel2 { get; }
        public int MagicType1 { get; } //0= no magic, 1= Elemental, 2= Arcane, 3= Nature, 4= Holy, 5= Healing, 6= Illusion
        public int MagicType2 { get; }//0= no magic, 1= Elemental, 2= Arcane, 3= Nature, 4= Holy, 5= Healing, 6= Illusion
        public int XPtoLevelMultiplier { get; }
        public int ArmorType1 { get; set; } //0 = no armor, 1= cloth, 2= leather, 3= chain, 4= plate, all other = default 
        public int ArmorType2 { get; set; } // 0 = no shield, 1 = shield, all other = default
        public int WeaponType1 { get; set; }  // 0 = unarmed, 1= melee, 2 = ranged all else = default
        public int ArmorBonus { get; }
        public int AttackBonus { get; }
        public int ManaBonus { get; }

        private ArchType(string dName, string jobTitle, int HpBPL, int atHp, int JobAtkBonus,int JobManaBonus, ArchSpecies defSpecies, 
            int maxSL1, int maxSL2, int magType1, int magType2, int xp2LMulti, int armorType1, int armorType2, int weaponType1, int ArBonus)
        {

            DefaultName = dName;          
            JobTitle = jobTitle;

            HpBonusPerLevel = HpBPL;
            AtHp = atHp;
            DefaultSpecies = defSpecies;
            MaxSpellLevel1 = maxSL1;
            MaxSpellLevel2 = maxSL2;
            MagicType1 = magType1;
            MagicType2 = magType2;
            XPtoLevelMultiplier = xp2LMulti;


            ArmorType1 = armorType1;
            ArmorType2 = armorType2;
            WeaponType1 = weaponType1;


        ArmorBonus = ArBonus;
            AttackBonus = JobAtkBonus;
            ManaBonus = JobManaBonus;

        }

        public Weapon ReadiedWeapon1 = EquipmentManager.EquippedWeapon1;
        public Armor ReadiedArmor1 = EquipmentManager.EquippedArmor1;
        public Armor ReadiedArmor2 = EquipmentManager.EquippedArmor2;





        // player classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, armorType1, armorType2, weaponType1, ArBonus)
        public static ArchType Paladin => new ArchType("Medrin", "Paladin", 5, 50, 5,3, DragonKin, 3, 0, 4, 0, 13, 4, 0, 1, 5);
        public static ArchType Bard => new ArchType("Tessa", "Bard", 2, 35, 2,2, DaemonKyne, 3, 6, 5, 6, 11, 2, 0, 1, 2);
        public static ArchType Cleric => new ArchType("Fray", "Cleric", 4, 40, 5, 5, Dwarf, 6, 6, 4, 5, 13, 3, 1, 1, 4);
        public static ArchType Sorcerer => new ArchType("Garth", "Sorcerer", 1, 10, 1, 8, Human, 6, 6, 2, 1, 12, 1, 0, 1, 1);
        public static ArchType Ranger => new ArchType("Nae'O'mii", "Ranger", 3, 30, 4, 2, Elf, 3, 5, 3, 0, 10, 2, 1, 2, 3);
        public static ArchType Rogue => new ArchType("Kayleigh", "Rogue", 2, 20, 3, 1, SmallFolk, 4, 0, 6, 0, 12, 2, 0, 1, 2);


        //Enemy classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, Armor, ArBonus)
         public static ArchType Peon => new ArchType("", "Peon", 3, 30, 4, 2, Goblin, 3, 5, 0, 0, 10, 0, 0, 1 , 1);
        public static ArchType Skirmisher => new ArchType("", "Skirmisher", 4, 40, 5, 5, Goblin, 6, 6, 0, 0, 13, 2, 1, 2, 2);
        public static ArchType Warboss => new ArchType("", "WarBoss", 1, 10, 1, 8, HobGoblin, 6, 6, 0, 0, 12, 4, 0, 1, 3);
        public static ArchType Champion => new ArchType("", "Champion", 3, 30, 4, 2, Gnoll, 3, 5, 2, 0, 10, 3, 1, 1, 3);
        public static ArchType Shaman => new ArchType("", "Shaman", 2, 20, 3, 1, Gnoll, 4, 0, 3, 1, 12, 1, 0, 1, 2);
        public static ArchType ClanChief => new ArchType("", "Clan Chief", 2, 20, 3, 1, Orc, 4, 0, 2, 5, 12, 4, 1,1, 4);

        // NPC Classes
        //(defName, jobTitle, HpBPL, atHp, JobAtkBonus, JobManaBonus, defSpecies,maxSL1, maxSL2, magType1, magType2, xp2LMulti, Armor, ArBonus)

        public static ArchType Peasant => new ArchType("", "Peasant", 4, 40, 5, 5, Human, 6, 6, 0, 0, 13, 0, 0, 1, 4);
        public static ArchType Merchant => new ArchType("", "Merchant", 1, 10, 1, 8, Human, 6, 6, 0, 0, 12, 1, 0, 1, 1);
        public static ArchType Noble => new ArchType("", "Nobel", 3, 30, 4, 2, Human, 3, 5, 0, 0, 10, 1, 0, 1, 3);
        public static ArchType Guard => new ArchType("", "Guard", 2, 20, 3, 1, Human, 4, 0, 0, 0, 12, 2, 1, 2, 2);
        public static ArchType Sheriff => new ArchType("", "Sheriff", 3, 30, 4, 2, Human, 3, 5, 6, 0, 10, 3, 1, 1, 3);
        public static ArchType Knight => new ArchType("", "Knight", 2, 20, 3, 1, Human, 4, 0, 2, 5, 12, 4,1 ,1 , 2);

    }
}

