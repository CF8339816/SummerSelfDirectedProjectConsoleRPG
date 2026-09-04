using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.Inventory;


namespace SummerSelfDirectedProjectConsoleRPG
{
    public class Weapon : Inventory
    {
        public string CombatRange { get; }
        public string WeaponType { get; }
        public int WeaponDamageMultiplier { get; set; }
        public int WeaponDiceType { get; set; }

        public string WeaponEquipped {  get; set; } 

        public bool IsWeaponEquipped= false;    

        public Weapon(string itemType, string itemName, int itmBonBaseAC, int itmBonBaseHp, int itmBonBaseAtk, int itmBonBaseMana, int weaponDamageMultiplier, int weaponDiceType, string combatRange, string weaponType, string weaponEquipped)
            : base(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana)

        {
            CombatRange = combatRange;
            WeaponType = weaponType;
            WeaponDamageMultiplier = weaponDamageMultiplier;
            WeaponDiceType = weaponDiceType;
            WeaponEquipped = WeaponEquipped;
         }

        //melee
        //( itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, weaponDamageMultiplier, weaponDiceType, combatRange, weaponType, weaponEquipped)

        public static Weapon Stick => new Weapon("Weapon", "Stick Of Destiny", 0, 0, 1, 0, 1, 4,"Melee", "Blunt", "No");
        public static Weapon Dagger => new Weapon("Weapon", "Bunny Smiter", 0, 0, 2, 0, 1, 6, "Melee", "Stab", "No");
        public static Weapon Spear => new Weapon("Weapon", "Poke Master 6000", 0, 0, 2, 0, 2, 4, "Melee", "Stab", "No");
        public static Weapon Mace => new Weapon("Weapon", "Wack-A-Gnoll", 0, 0, 3, 0, 2, 6, "Melee", "Blunt", "No");
        public static Weapon Axe => new Weapon("Weapon", "The Lumbinator", 0, 0, 3, 0, 2, 6, "Melee", "Slash", "No");
        public static Weapon Sword => new Weapon("Weapon", "Vorasiously Sharp Metal Stick", 0, 0, 3, 0, 2, 8, "Melee", "Slash", "No");



        //ranged
        //( itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, weaponDamageMultiplier, weaponDiceType, combatRange, weaponType, weaponEquipped)
        public static Weapon Sling => new Weapon("Weapon", "David's Fav Banana Hammock", 0, 0, 1, 0, 1, 4, "Ranged", "Blunt", "No");
        public static Weapon ShortBow => new Weapon("Weapon", "Compact PewPew", 0, 0, 2, 0, 2, 4, "Ranged", "Stab", "No");
        public static Weapon LongBow => new Weapon("Weapon", "The Hooded Robin", 0, 0, 2, 0, 2, 6, "Ranged", "Stab", "No");
        public static Weapon CompoundBow => new Weapon("Weapon", "The Ram Bow", 0, 0, 3, 0, 4, 4, "Ranged", "Stab", "No");



    }
}
