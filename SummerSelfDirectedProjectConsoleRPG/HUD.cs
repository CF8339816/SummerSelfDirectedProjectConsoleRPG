using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.ArchSpecies;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;
using static SummerSelfDirectedProjectConsoleRPG.PC;
using static SummerSelfDirectedProjectConsoleRPG.Program;


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
            Console.WriteLine("Please choose a character class from the following list:\n 1) Paladin 2) Bard, 3) Cleric, 4) Rogue, 5) Ranger, 6) Sorcerer.\n please type a number between 1-6");
            Console.ReadLine();

            switch (ArchType)
            {
                case ArchType.Paladin:
                    PC.arcJob = Paladin;
                    Console.WriteLine("You have chosen to be a Paladin, 'Stalward and true... With great power comes...SMITE!!!!!'");
                    break;

                case ArchType.Bard:
                    PC.arcJob = Bard;
                    Console.WriteLine("You have chosen to be a Bard, 'I'm not the problem.... The story this would make is the problem...'");
                    break;

                case ArchType.Cleric:
                    PC.arcJob = Cleric;
                    Console.WriteLine("You have chosen to be a Cleric, 'Oh Lawd give me the strngth to heal these nitwits....'");
                    break;

                case ArchType.Rogue:
                    PC.arcJob = Rogue;
                    Console.WriteLine("You have chosen to be a Rogue , 'Sneaky, sneaky  Suggah...'");
                    break;

                case ArchType.Ranger:
                    PC.arcJob = Ranger;
                    Console.WriteLine("You have chosen to be a Ranger, 'Be Verry Verry quiet... I'm hunting Were-woofs.'");
                    break;

                case ArchType.Sorcerer:
                    PC.arcJob = Sorcerer;
                    Console.WriteLine("You have chosen to be a Sorcerer, 'Phenomional Cosmic Power...About to be sued by Disney...'");
                    break;
            }
        }


        //m3

        public static void ChooseMySpecies()
        {
            Console.WriteLine("Please choose a character Species from the following list:\n 1) DragonKin 2) DaemonKyne, 3) Dwarf, 4) Elf, 5) Human, 6) SmallFolk.\n please type a number between 1-6");
            Console.ReadLine();

            switch (ArchSpecies)
            {
                case ArchSpecies.DragonKin:
                    PC.arcSpecies = DragonKin;
                    Console.WriteLine("You have chosen to be a DragonKin,\n 'I'm an ALL POWERFUL DRAGON!!!!..... No... Really.'");
                    break;

                case ArchSpecies.DaemonKyne:
                    PC.arcSpecies = DaemonKyne;
                    Console.WriteLine("You have chosen to be a DaemonKyne,\n 'My parents? .....Well... It's complicated.'");
                    break;

                case ArchSpecies.Dwarf:
                    PC.arcSpecies = Dwarf;
                    Console.WriteLine("You have chosen to be a Dwarf,\n 'If ye Likem Hairy...I got whatcha want!'");
                    break;

                case ArchSpecies.Elf:
                    PC.arcSpecies = Elf;
                    Console.WriteLine("You have chosen to be a Elf,\n 'What do I see with your Elvish Eyes? You may not wan to know...'");
                    break;

                case ArchSpecies.Human:
                    PC.arcSpecies = Human;
                    Console.WriteLine("You have chosen to be a Human,\n 'I don't know why other Species get nervouse when I'm around...'");
                    break;

                case ArchSpecies.SmallFolk:
                    PC.arcSpecies = SmallFolk;
                    Console.WriteLine("You have chosen to be a SmallFolk,\n 'Hey... mind were you step please...no?.......YOINK!'");
                    break;
            }
        }
    }
}
