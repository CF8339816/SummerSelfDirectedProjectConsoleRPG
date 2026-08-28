using System;
using System.Collections.Generic;
using System.Data;
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
        public const int MaxNameLength = 15;
        public static string nameChoice { get; set; } = "";
        public static ArchType jobType { get; set; }
        public static ArchSpecies SpeciesChoice { get; set; }





    {
        //m1
        public static void NameMyCharacter()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;

            
            {
                Console.WriteLine($"Would you like to name your character (choice 1) or use default (choice 2){ArchType.dName}?");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("What is your character's name");
                     Console.ForegroundColor = ConsoleColor.Blue;
                    nameChoice = Console.ReadLine();
                    // Program nameUsed = Console.ReadLine();
                   
                 
                    while (true)
                    {
                        if (nameChoice.Length <= Program.MaxNameLLength) break;

                        Console.WriteLine($"Error: Input is too long! please limit to 15 characters({Program.nameUsed.Length}/{Program.MaxNameLLength})");
                        NameMyCharacter();
                    }
                }
                else if (choice == 2)
                {
                    nameChoice = PC.arcJob.ArchType.dName;
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

            bool SelectJob = false;
            while (!SelectJob)
            {
                Console.WriteLine("Please choose a character class from the following list:\n 1) Paladin 2) Bard, 3) Cleric, 4) Rogue, 5) Ranger, 6) Sorcerer.\n please type a number between 1-6");
                // Console.ReadLine();
                //int choice = Convert.ToInt32(Console.ReadLine());
                int jobSelect = Convert.ToInt32(Console.ReadLine());
                switch (jobSelect)
                {
                    case 1:
                        jobType = Paladin;
                        Console.WriteLine("You have chosen to be a Paladin, 'Stalward and true... With great power comes...SMITE!!!!!'");
                        SelectJob = true;
                        break;

                    case 2:
                        jobType = Bard;
                        Console.WriteLine("You have chosen to be a Bard, 'I'm not the problem.... The story this would make is the problem...'");
                        SelectJob = true;
                        break;

                    case 3:
                        jobType = Cleric;
                        Console.WriteLine("You have chosen to be a Cleric, 'Oh Lawd give me the strngth to heal these nitwits....'");
                        SelectJob = true;
                        break;

                    case 4:
                        jobType = Rogue;
                        Console.WriteLine("You have chosen to be a Rogue , 'Sneaky, sneaky  Suggah...'");
                        SelectJob = true;
                        break;

                    case 5:
                        jobType = Ranger;
                        Console.WriteLine("You have chosen to be a Ranger, 'Be Verry Verry quiet... I'm hunting Were-woofs.'");
                        SelectJob = true;
                        break;

                    case 6:
                        jobType = Sorcerer;
                        Console.WriteLine("You have chosen to be a Sorcerer, 'Phenomional Cosmic Power...About to be sued by Disney...'");
                        SelectJob = true;
                        break;
                }
            }
        }


        //m3

        public static void ChooseMySpecies()
        {
            bool SelectSpecies = false;
            while (!SelectSpecies)
            {
                Console.WriteLine("Please choose a character Species from the following list:\n 1) DragonKin 2) DaemonKyne, 3) Dwarf, 4) Elf, 5) Human, 6) SmallFolk.\n please type a number between 1-6");
                int speciesSelect = Convert.ToInt32(Console.ReadLine());

                switch (speciesSelect)
                {
                    case 1:
                        SpeciesChoice = DragonKin;
                        Console.WriteLine("You have chosen to be a DragonKin,\n 'I'm an ALL POWERFUL DRAGON!!!!..... No... Really.'");
                        SelectSpecies = true;
                        break;

                    case 2:
                        SpeciesChoice = DaemonKyne;
                        Console.WriteLine("You have chosen to be a DaemonKyne,\n 'My parents? .....Well... It's complicated.'");
                        SelectSpecies = true;
                        break;

                    case 3:
                        SpeciesChoice = Dwarf;
                        Console.WriteLine("You have chosen to be a Dwarf,\n 'If ye Likem Hairy...I got whatcha want!'");
                        SelectSpecies = true;
                        break;

                    case 4:
                        SpeciesChoice = Elf;
                        Console.WriteLine("You have chosen to be a Elf,\n 'What do I see with your Elvish Eyes? You may not wan to know...'");
                        SelectSpecies = true; 
                        break;

                    case 5:
                        SpeciesChoice = Human;
                        Console.WriteLine("You have chosen to be a Human,\n 'I don't know why other Species get nervouse when I'm around...'");
                        SelectSpecies = true; 
                        break;

                    case 6:
                        SpeciesChoice = SmallFolk;
                        Console.WriteLine("You have chosen to be a SmallFolk,\n 'Hey... mind were you step please...no?.......YOINK!'");
                        SelectSpecies = true; 
                        break;
                }
            }
        }
    }
}
