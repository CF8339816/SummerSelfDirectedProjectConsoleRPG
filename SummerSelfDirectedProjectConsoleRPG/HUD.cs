using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    //static public string CharRole { get;  }


      public class HUD
    {
        //m1
        public static void NameMyCharacter()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;

            
            {
                Console.WriteLine($"Would you like to name your character (choice 1) or use default (choice 2){ArchType.dName}?");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("What is your character's name");
                     Console.ForegroundColor = ConsoleColor.Blue;
                    Program.nameUsed = Console.ReadLine();
                    // Program nameUsed = Console.ReadLine();
                   
                 
                    while (true)
                    {
                        if (Program.nameUsed.Length <= Program.MaxNameLLength) break;

                        Console.WriteLine($"Error: Input is too long! please limit to 15 characters({Program.nameUsed.Length}/{Program.MaxNameLLength})");
                        NameMyCharacter();
                    }
                }
                else if (choice == 2)
                {
                    Program nameUsed = ArchType.dName;
                }
                else
                {
                    Console.WriteLine("That is not a valid choice please choose again");
                    NameMyCharacter();
                }

            }

            Console.ResetColor();
        }
        //m2

        public static void ChooseMyClass()
        {
            Console.WriteLine("Please choose a character class from the following list:\n 1) Paladon 2) Bard, 3) Cleric, 4) Rogue, 5) Ranger, 6) Sorcerer.");
            Console.ReadLine();

            switch (ArchType)
            {
                case ArchType.Paladin:
                    arcJob = Paladin;
                    Console.WriteLine("You have chosen to be a Paladin, 'Stalward and true... With great power comes...SMITE!!!!!'");
                    break;

                case ArchType.Bard:
                    arcJob = Bard;
                    Console.WriteLine("You have chosen to be a Bard, 'I'm not the problem.... The story this would make is the problem...'");
                    break;

                case ArchType.Cleric:
                    arcJob = Cleric;
                    Console.WriteLine("You have chosen to be a Cleric, 'Oh Lawd give me the strngth to heal these nitwits....'");
                    break;

                case ArchType.Rogue:
                    arcJob = Rogue;
                    Console.WriteLine("You have chosen to be a Rogue , 'Sneaky, sneaky  Suggah...'");
                    break;

                case ArchType.Ranger:
                    arcJob = Ranger;
                    Console.WriteLine("You have chosen to be a Ranger, 'What do you see with your Elvish Eyes.'");
                    break;

                case ArchType.Sorcerer:
                    arcJob = Sorcerer;
                    Console.WriteLine("You have chosen to be a Sorcerer, 'Phenomional Cosmic Power...About to be sued by Disney...'");
                    break;
            }
        }
    }
}
