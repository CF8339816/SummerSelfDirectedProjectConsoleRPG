using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class Inventory
    {
        public string _itemType { get; set; }
        public string _itemName{ get; set; }
        public int itemBaseACBonus { get; set; }
        public int itemBaseHpBonus { get; set; }
        public int itemBaseAttackBonus { get; set; }
        public int itemBaseManaBonus { get; set; }

        
        public Inventory(string itemType, string itemName, int itmBonBaseAC, int itmBonBaseHp, int itmBonBaseAtk, int itmBonBaseMana)
        {
            _itemType = itemType;
            _itemName = itemName;

            itemBaseACBonus = itmBonBaseAC;
            itemBaseHpBonus = itmBonBaseHp;
            itemBaseAttackBonus = itmBonBaseAtk;
            itemBaseManaBonus = itmBonBaseMana;
                        
        }

    }
}
