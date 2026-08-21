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

        static void (ChooseMyClass)
    {
    Console.WriteLine("Please choose a character class from the following list:\n 1) Paladon 2) Bard, 3) Cleric, 4) Rogue, 5) Ranger, 6) Sorcerer.");
    Console.ReadLine();

    switch (CharacterRole)
    {
        case CharRole.Paladin:
            
            arcType = Paladin;
            Console.WriteLine("You have chosen to be a Paladin, 'Stalward and true... With great power comes...SMITE!!!!!'");
            break;

        case CharRole.Bard:
            arcType = Bard;
            Console.WriteLine("You have chosen to be a Bard, 'I'm not the problem.... the story this would make is the problem...'");
            break;
        
        case CharRole.Cleric:
            arcType = Cleric;
            Console.WriteLine("You have chosen to be a Cleric, 'Oh Lawd give me the strngth to heal these nitwits....'");
            break;
       
        case CharRole.Rogue:
            arcType = Rogue;
            Console.WriteLine("You have chosen to be a Rogue , 'Sneaky, sneaky  Suggah...'");
            break;
       
        case CharRole.Ranger:
            arcType = Ranger;
            Console.WriteLine("You have chosen to be a Ranger, 'What do you see with your Elvish Eyes.'");
            break;
        
        case CharRole.Sorcerer;
            arcType = Sorcerer

            Console.WriteLine("You have chosen to be a Sorcerer, 'Phenomional Cosmic Power...About to be sued by Disney...'");
            break;
    }
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