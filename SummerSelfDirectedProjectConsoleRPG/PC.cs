using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG


	public class PC : Character
{

	public int pLHp = 100;
	public static int plXP = 0;
	public static int plLevel = 0;

	public static string arcType = ArcType.arcType;

	public static string nameUsed;

	public PC(string type, string name, int hp, int speed, int dex, int ac, string magic, int strength, char symbol, ConsoleColor color, int attack,
	 int mana, string nameUsed, string arcType, int plHpPerLevBonus, int level, int mana, int xp, int armorValue, int spellsPerLevel) :
	 base(type, name, hp, speed, dex, ac, magic, strength, symbol, ConsoleColor color, attack,
	  mana, nameUsed, arcType, plHpPerLevBonus, level, mana, xp, armorValue, spellsPerLevel)

	{

	}

}

//    static void (NameMyCharacter)
//{
//Console WriteLine("Would you like to name your character (choice 1) or use default (choice 2)?")

//if (Console readLine == "1" )
//{
//	  Console.WriteLine("What is your character's name");
          
//            nameUsed = Console.ReadLine();
			
//}
//else if (Console readLine == "2" )
//{
//	nameUsed = Paladin.defaultName;
//}
//else
//{
//    Console WriteLine("That is not a valid choice please choose again");
//    (NameMyCharacter);
//}

//}

}
