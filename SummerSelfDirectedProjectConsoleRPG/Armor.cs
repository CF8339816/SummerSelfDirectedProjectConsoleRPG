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

        public Armor(string itemType, string itemName, int itmBonBaseAC, int itmBonBaseHp, int itmBonBaseAtk, int itmBonBaseMana, int armorBonusAC, int armorMovementPenalty, int toughness, string armorType)
            : base(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana)

        {
            Toughness = toughness;
            ArmorType = armorType;
            ArmorBonusAC = armorBonusAC;
            ArmorMovementPenalty = armorMovementPenalty;

        }





        //Cloth
        //       (string itemType, string itemName, int itmBonBaseAC, int itmBonBaseHp, int itmBonBaseAtk, int itmBonBaseMana, int armorBonusAC, int armorMovementPenalty, int toughness, string armorType)
        public static Armor worn => new Armor("Armor", "Threadbaren and Worn", 0, 0, 0, 0, 1,0, 5, "Cloth");
        public static Armor WellMade => new Armor("Armor", "Thickly Stitched", 0, 0, 0, 0, 2, 0, 10, "Cloth");
        public static Armor MasterWork => new Armor("Armor", "MasterWork Layered Cloth", 0, 0, 0, 0, 3, 0, 15, "Cloth");




        //Leather



        //Chain



        //Plate



        //Shield



    }

}
