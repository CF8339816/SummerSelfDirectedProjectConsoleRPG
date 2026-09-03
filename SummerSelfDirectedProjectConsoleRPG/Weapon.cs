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

        public Weapon(string itemType, string itemName, int itmBonBaseAC, int itmBonBaseHp, int itmBonBaseAtk, int itmBonBaseMana, int weaponDamageMultiplier, int weaponDiceType, string combatRange, string weaponType)
            : base(itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana)

        {
            CombatRange = combatRange;
            WeaponType = weaponType;
            WeaponDamageMultiplier = weaponDamageMultiplier;
            WeaponDiceType = weaponDiceType;

         }

        //melee
        //( itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, weaponDamageMultiplier, weaponDiceType, combatRange, weaponType)

        public static Weapon Stick => new Weapon("Weapon", "Stick Of Destiny", 0, 0, 1, 0, 1, 4,"Melee", "Blunt");
        public static Weapon Dagger => new Weapon("Weapon", "Bunny Smiter", 0, 0, 2, 0, 1, 6, "Melee", "Stab");
        public static Weapon Spear => new Weapon("Weapon", "Poke Master 6000", 0, 0, 2, 0, 2, 4, "Melee", "Stab");
        public static Weapon Mace => new Weapon("Weapon", "Wack-A-Gnoll", 0, 0, 3, 0, 2, 6, "Melee", "Blunt");
        public static Weapon Axe => new Weapon("Weapon", "The Lumbinator", 0, 0, 3, 0, 2, 6, "Melee", "Slash");
        public static Weapon Sword => new Weapon("Weapon", "Vorasiously Sharp Metal Stick", 0, 0, 3, 0, 2, 8, "Melee", "Slash");



        //ranged
        //( itemType, itemName, itmBonBaseAC, itmBonBaseHp, itmBonBaseAtk, itmBonBaseMana, weaponDamageMultiplier, weaponDiceType, combatRange, weaponType)
        public static Weapon Sling => new Weapon("Weapon", "David's Fav Banana Hammock", 0, 0, 1, 0, 1, 4, "Ranged", "Blunt");
        public static Weapon ShortBow => new Weapon("Weapon", "Compact PewPew", 0, 0, 2, 0, 2, 4, "Ranged", "Stab");
        public static Weapon LongBow => new Weapon("Weapon", "The Hooded Robin", 0, 0, 2, 0, 2, 6, "Ranged", "Stab");
        public static Weapon CompoundBow => new Weapon("Weapon", "The Ram Bow", 0, 0, 3, 0, 4, 4, "Ranged", "Stab");



    }
}
