using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class Armor: Inventory
    {

        public string CombatRange { get; }
        public string ArmorType { get; }
        public int WeaponDamageMultiplier { get; set; }
        public int WeaponDiceType { get; set; }

        public Armor(string itemType, string itemName, int itmBonBaseAC, int itmBonBaseHp, int itmBonBaseAtk, int itmBonBaseMana, int weaponDamageMultiplier, int weaponDiceType, string combatRange, string weaponType)
            : base(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana)

        {
            CombatRange = combatRange;
            ArmorType = weaponType;
            WeaponDamageMultiplier = weaponDamageMultiplier;
            WeaponDiceType = weaponDiceType;

        }





        //Cloth



        //Leather



        //Chain



        //Plate



        //Shield



    }

}
