using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{

	class Program
	{
		public string nameUsed;
		public string name;

	public static int hp = Character.hp + PC.PcHp + ArcType.AtHp;
	 public static PC myPC = newPC(type, " ", hp, speed, dex, ac, magic, strength, symbol, ConsoleColor color, attack,
		  mana, nameUsed, arcType, plHpPerLevBonus, level, mana, xp, armorValue, spellsPerLevel);


		static void Main()
		{
			
			PC.(NameMyCharacter);








        }


        static void NameMyCharacter()
{
			Console.WriteLine("Would you like to name your character (choice 1) or use default (choice 2)?");
int choice = Console.ReadLine();
if (choice == 1 )
{
	  Console.WriteLine("What is your character's name");
       Console.ReadLine();   
            nameUsed = Console.ReadLine();
			
}
else if (choice == 2 )
{
	nameUsed = Paladin.defaultName;
}
else
{
    Console WriteLine("That is not a valid choice please choose again");
    (NameMyCharacter);
}

}

	}
}