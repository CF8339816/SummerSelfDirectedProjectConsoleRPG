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
    public class HUD
    {
        public const int MaxNameLength = 15;
        public static string nameChoice { get; set; } 
        public static ArchType jobType { get; set; }
        public static string _Job;
        public static ArchSpecies SpeciesChoice { get; set; }
        public static string _Species;
        public static ArchType Defaultspecies { get; set; }

        public static PC Player { get; set; }   
        //m1
        public static void NameMyCharacter()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            bool validName = false;

            while (!validName)
            {
                Console.WriteLine($"Would you like to name your character (choice 1) or use default (choice 2){HUD.jobType.DefaultName}?");
                Console.ForegroundColor = ConsoleColor.Blue;
                int choice = Convert.ToInt32(Console.ReadLine());
              
                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("What is your character's name");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    nameChoice = Console.ReadLine();
                  
                    while (true)
                    {
                        if (nameChoice.Length <= Program.MaxNameLLength) break;

                        Console.WriteLine($"Error: Input is too long! please limit to 15 characters({HUD.nameChoice.Length}/{Program.MaxNameLLength})");
                        NameMyCharacter();
                    }

                    validName = true;
                }
                else if (choice == 2)
                {
                    nameChoice = HUD.jobType.DefaultName;

                    validName = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("That is not a valid choice please choose again");
                    NameMyCharacter();
                }

            }

            Console.ResetColor();
        }
        //m2

        public static void ChooseMyClass()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            bool SelectJob = false;
            while (!SelectJob)
            {
                Console.WriteLine("Please choose a character class from the following list:\n 1) Paladin 2) Bard, 3) Cleric, 4) Rogue, 5) Ranger, 6) Sorcerer.\n please type a number between 1-6");
                Console.ForegroundColor = ConsoleColor.Blue;
                int jobSelect = Convert.ToInt32(Console.ReadLine());
                switch (jobSelect)
                {
                    case 1:
                        jobType = ArchType.Paladin;
                        _Job = "Paladin";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Paladin, 'Stalward and true... With great power comes...SMITE!!!!!'");
                        SelectJob = true;
                        break;

                    case 2:
                        jobType = ArchType.Bard;
                        _Job = "Bard";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Bard, 'I'm not the problem.... The story this would make is the problem...'");
                        SelectJob = true;
                        break;

                    case 3:
                        jobType = ArchType.Cleric;
                        _Job = "Cleric";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Cleric, 'Oh Lawd give me the strngth to heal these nitwits....'");
                        SelectJob = true;
                        break;

                    case 4:
                        jobType = ArchType.Rogue;
                        _Job = "Rogue";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Rogue , 'Sneaky, sneaky  Suggah...'");
                        SelectJob = true;
                        break;

                    case 5:
                        jobType = ArchType.Ranger;
                        _Job = "Ranger";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Ranger, 'Be Verry Verry quiet... I'm hunting Were-woofs.'");
                        SelectJob = true;
                        break;

                    case 6:
                        jobType = ArchType.Sorcerer;
                        _Job = "Sorcerer";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Sorcerer, 'Phenomional Cosmic Power...About to be sued by Disney...'");
                        SelectJob = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Invalid choice. Please pick a number from 1 to 6.");
                        break;
                }
            }

       
        }


        //m3

        public static void ChooseMySpecies()
        {
            bool SelectSpecies = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;


            while (!SelectSpecies)
            {
                Console.WriteLine($"Would you like to choose your character Species (choice 1) or use default (choice 2) {HUD.jobType.DefaultSpecies.SpeciesTitle}?");
                Console.ForegroundColor = ConsoleColor.Blue;
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please choose a character Species from the following list:\n 1) DragonKin 2) DaemonKyne, 3) Dwarf, 4) Elf, 5) Human, 6) SmallFolk.\n please type a number between 1-6");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int speciesSelect = Convert.ToInt32(Console.ReadLine());

                    switch (speciesSelect)
                    {
                        case 1:
                            SpeciesChoice = ArchSpecies.DragonKin;
                            _Species = "DragonKin";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a DragonKin,\n 'I'm an ALL POWERFUL DRAGON!!!!..... No... Really.'");
                            SelectSpecies = true;
                            break;

                        case 2:
                            SpeciesChoice = ArchSpecies.DaemonKyne;
                            _Species = "DaemonKyne";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a DaemonKyne,\n 'My parents? .....Well... It's complicated.'");
                            SelectSpecies = true;
                            break;

                        case 3:
                            SpeciesChoice = ArchSpecies.Dwarf;
                            _Species = "Dwarf";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a Dwarf,\n 'If ye Likem Hairy...I got whatcha want!'");
                            SelectSpecies = true;
                            break;

                        case 4:
                            SpeciesChoice = ArchSpecies.Elf;
                            _Species = "Elf";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a Elf,\n 'What do I see with your Elvish Eyes? You may not want to know...'");
                            SelectSpecies = true;
                            break;

                        case 5:
                            SpeciesChoice = ArchSpecies.Human;
                            _Species = "Human";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a Human,\n 'I don't know why other Species get nervouse when I'm around...'");
                            SelectSpecies = true;
                            break;

                        case 6:
                            SpeciesChoice = ArchSpecies.SmallFolk;
                            _Species = "SmallFolk";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a SmallFolk,\n 'Hey... mind were you step please...no?.......YOINK!'");
                            SelectSpecies = true;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Invalid choice. Please pick a number from 1 to 6.");
                            break;
                    }
                }

                else if (choice == 2)
                {
                    SpeciesChoice = HUD.jobType.DefaultSpecies;

                    SelectSpecies = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("That is not a valid choice please choose again");
                    ChooseMySpecies();
                }
            }
        }


        //m4

        public static void StatBlock()
        {

        }

        //m5

        public static void Instructions()
        {
            Console.SetCursorPosition(0, 26);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Press any Key to start... Use W,A,S,D  or arrow keys to move around the map...Press 'Q' to exit...\n" +
                "Fight enemies by manouvering to them or try to avoid them...\n" +
                " Lava '%' will damage you, Water 'w' will heal you, '@' and '*' will port you forward and back through the maps");
            Console.ResetColor();
        }

        //m6

        public static void Farewell()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.SetCursorPosition(60, 25);
            Console.WriteLine("We hope you come back soon... Please press any key to exit");
            Console.ReadKey(true);
            Console.WriteLine("\n\n\n\n\n\n");
            Console.ResetColor();

        }

        //m7

       public static void PcCreatinConfirmation(PC Player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"--- Character Creation Complete ---");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Name: \u001b[36m{Player.Name}\u001b[33m  | (\u001b[36m{Player.ArcSpecies.Vision} Vision\u001b[33m)");
            Console.WriteLine($"Class: \u001b[36m{Player.ArcJob.JobTitle} \u001b[33mArchetype  | Player Species: \u001b[36m{Player.ArcSpecies.SpeciesTitle}\u001b[33m");
            Console.WriteLine($"HP: \u001b[36m{Program.PlayerHp} \u001b[33m  | AC: \u001b[36m{Program.PlayerAC}\u001b[33m");
            Console.WriteLine($"Granted Spells: \u001b[36m{Player.ArcSpecies.BonusSpellsSpecies1} \u001b[33m | \u001b[36m{Player.ArcSpecies.BonusSpellsSpecies2}\u001b[33m");
            Console.WriteLine($"Magic type 1:\u001b[36m {Player.ArcJob.MagicType1} \u001b[33m | Magic type 2: \u001b[36m{Player.ArcJob.MagicType2}\u001b[33m");
            Console.WriteLine($"Max Level Magic type 1: \u001b[36m{Player.ArcJob.MaxSpellLevel1} \u001b[33m | Max Level Magic type 2: \u001b[36m{Player.ArcJob.MaxSpellLevel2}\u001b[33m");
            Console.WriteLine($"Player Icon: \u001b[36m{Player._symbol} \u001b[33m | Icon Color: \u001b[36m{Player._color}\u001b[33m");
            Console.WriteLine($"Player Attack: \u001b[36m{Program.PlayerATK} \u001b[33m | Player Mana: \u001b[36m{Program.PlayerMP}\u001b[33m");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------\n");
        }




    }
}


