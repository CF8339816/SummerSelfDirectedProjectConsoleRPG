using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class Armor: Inventory
    {

        public int Toughness { get; }
        public string ArmorType { get; }
        public int ArmorBonusAC { get; set; }
        public int ArmorMovementPenalty { get; set; }
        public string ArmorEquipped {  get; set; }  

        public bool IsArmorEquipped = false;    

        public Armor(string itemType, string itemName, int itmBonBaseAC, int itmBonBaseHp, int itmBonBaseAtk, int itmBonBaseMana, int armorBonusAC, int armorMovementPenalty, int toughness, string armorType, string armorEquipped)
            : base(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana)

        {
            Toughness = toughness;
            ArmorType = armorType;
            ArmorBonusAC = armorBonusAC;
            ArmorMovementPenalty = armorMovementPenalty;
            ArmorEquipped = ArmorEquipped;
        }

        //Cloth
        //(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, armorBonusAC, armorMovementPenalty, toughness, armorType, armorEquipped)
        public static Armor wornCloth => new Armor("Armor", "Threadbaren and Worn", 0, 0, 0, 0, 1,0, 5, "Cloth", "No");
        public static Armor WellMadeCloth => new Armor("Armor", "Thickly Stitched Padded Cloth", 0, 0, 0, 0, 2, 0, 10, "Cloth", "No");
        public static Armor MasterWorkCloth => new Armor("Armor", "MasterWork Layered Cloth", 0, 0, 0, 0, 3, 0, 15, "Cloth", "No");


        //Leather
        //(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, armorBonusAC, armorMovementPenalty, toughness, armorType, armorEquipped)
        public static Armor wornLeather => new Armor("Armor", "old Leather Jerkin", 0, 0, 0, 0, 2, 0, 10, "Leather", "No");
        public static Armor WellMadeLeather => new Armor("Armor", "Hardened Leather", 0, 0, 0, 0, 3, 0, 15, "Leather", "No");
        public static Armor MasterWorkLeather => new Armor("Armor", "MasterWork Studded Leather", 0, 0, 0, 0, 4, 0, 20, "Leather", "No");


        //Chain
        //(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, armorBonusAC, armorMovementPenalty, toughness, armorType, armorEquipped)
        public static Armor wornChain => new Armor("Armor", "Well Used Ring Mail", 0, 0, 0, 0, 3, 0, 15, "Chain", "No");
        public static Armor WellMadeChain => new Armor("Armor", "Scale Mail", 0, 0, 0, 0, 4, 0, 20, "Chain", "No");
        public static Armor MasterWorkChain => new Armor("Armor", "MasterWork Chainmail", 0, 0, 0, 0, 5, 0, 25, "Chain", "No");


        //Plate
        //(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, armorBonusAC, armorMovementPenalty, toughness, armorType, armorEquipped)
        public static Armor wornPlate => new Armor("Armor", "Scavenged Piecemeal Plate", 0, 0, 0, 0, 4, 0, 20, "Plate", "No");
        public static Armor WellMadePlate => new Armor("Armor", "Servicable Half Plate", 0, 0, 0, 0, 5, 0, 25, "Plate", "No");
        public static Armor MasterWorkPlate => new Armor("Armor", "MasterWork Full Plate ", 0, 0, 0, 0, 6, 0, 30, "Plate", "No");


        //Shield
        //(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, armorBonusAC, armorMovementPenalty, toughness, armorType, armorEquipped)
        public static Armor wornShield => new Armor("Armor", "Buckler", 0, 0, 0, 0, 1, 0, 5, "Shield", "No" );
        public static Armor WellMadeShield => new Armor("Armor", "Shield", 0, 0, 0, 0, 2, 0, 10, "Shield", "No");
        public static Armor MasterWorkShield => new Armor("Armor", "Tower Shield", 0, 0, 0, 0, 3, 0, 15, "Shield", "No");


    }

}
