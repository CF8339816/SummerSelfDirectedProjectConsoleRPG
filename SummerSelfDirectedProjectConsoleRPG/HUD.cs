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
        public static ArchType Defaultspecies;

        public static int SetAr1 { get; set; }
        public static string SpellSchool1 { get; set; }
        public static string SpellSchool2 { get; set; }
        public static Armor armor1Type { get; set; }
        public static string _armor1;
        public static Armor armor2Type { get; set; }
        public static string _armor2;
        public static Weapon weapon1Type { get; set; }
        public static string _weapon1;


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
                        Console.WriteLine("You have chosen to be a Paladin,\n  \u001b[36m'Stalward and true... With great power comes...SMITE!!!!!' \u001b[33m");
                        SelectJob = true;
                        break;

                    case 2:
                        jobType = ArchType.Bard;
                        _Job = "Bard";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Bard,\n  \u001b[36m'I'm not the problem.... The story this would make is the problem...' \u001b[33m");
                        SelectJob = true;
                        break;

                    case 3:
                        jobType = ArchType.Cleric;
                        _Job = "Cleric";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Cleric,\n  \u001b[36m'Oh Lawd give me the strngth to heal these nitwits....' \u001b[33m");
                        SelectJob = true;
                        break;

                    case 4:
                        jobType = ArchType.Rogue;
                        _Job = "Rogue";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Rogue,\n \u001b[36m'Sneaky, sneaky  Suggah...'\u001b[33m");
                        SelectJob = true;
                        break;

                    case 5:
                        jobType = ArchType.Ranger;
                        _Job = "Ranger";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Ranger,\n \u001b[36m'Be Verry Verry quiet... I'm hunting Were-woofs.'\u001b[33m");
                        SelectJob = true;
                        break;

                    case 6:
                        jobType = ArchType.Sorcerer;
                        _Job = "Sorcerer"; 
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have chosen to be a Sorcerer, \n \u001b[36m'Phenomional Cosmic Power...About to be sued by Disney...'v\u001b[33m");
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
                            Console.WriteLine("You have chosen to be a DragonKin,\n  \u001b[36m'I'm an ALL POWERFUL DRAGON!!!!..... No... Really.' \u001b[33m");
                            SelectSpecies = true;
                            break;

                        case 2:
                            SpeciesChoice = ArchSpecies.DaemonKyne;
                            _Species = "DaemonKyne";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a DaemonKyne,\n  \u001b[36m'My parents? .....Well... It's complicated.' \u001b[33m");
                            SelectSpecies = true;
                            break;

                        case 3:
                            SpeciesChoice = ArchSpecies.Dwarf;
                            _Species = "Dwarf";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a Dwarf,\n  \u001b[36m'If ye Likem Hairy...I got whatcha want!' \u001b[33m");
                            SelectSpecies = true;
                            break;

                        case 4:
                            SpeciesChoice = ArchSpecies.Elf;
                            _Species = "Elf";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a Elf,\n  \u001b[36m'What do I see with your Elvish Eyes? You may not want to know...' \u001b[33m");
                            SelectSpecies = true;
                            break;

                        case 5:
                            SpeciesChoice = ArchSpecies.Human;
                            _Species = "Human";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a Human,\n  \u001b[36m'I don't know why other Species get nervouse when I'm around...' \u001b[33m");
                            SelectSpecies = true;
                            break;

                        case 6:
                            SpeciesChoice = ArchSpecies.SmallFolk;
                            _Species = "SmallFolk";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("You have chosen to be a SmallFolk,\n  \u001b[36m'Hey... mind were you step please...no?.......YOINK!' \u001b[33m");
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

       

        //m5

        public static void Instructions()
        {
            Console.SetCursorPosition(0, 38);
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
            SpellSchool(Player);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-------------- Character Creation Complete --------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Name: \u001b[36m{Player.Name}\u001b[33m  | (\u001b[36m{Player.ArcSpecies.Vision} Vision\u001b[33m)");
            Console.WriteLine($"Class: \u001b[36m{Player.ArcJob.JobTitle} \u001b[33mArchetype  | Player Species: \u001b[36m{Player.ArcSpecies.SpeciesTitle}\u001b[33m");
            Console.WriteLine($"HP: \u001b[36m{Program.PlayerHp} \u001b[33m  | AC: \u001b[36m{Program.PlayerAC}\u001b[33m");
            Console.WriteLine($"Granted Spells: \u001b[36m{Player.ArcSpecies.BonusSpellsSpecies1} \u001b[33m | \u001b[36m{Player.ArcSpecies.BonusSpellsSpecies2}\u001b[33m");
            Console.WriteLine($"Magic type 1:\u001b[36m {HUD.SpellSchool1} \u001b[33m | Magic type 2: \u001b[36m{HUD.SpellSchool2}\u001b[33m");
            Console.WriteLine($"Max Level Magic type 1: \u001b[36m{Player.ArcJob.MaxSpellLevel1} \u001b[33m | Max Level Magic type 2: \u001b[36m{Player.ArcJob.MaxSpellLevel2}\u001b[33m");
            Console.WriteLine($"Player Icon: \u001b[36m{Player._symbol} \u001b[33m | Icon Color: \u001b[36m{Player._color}\u001b[33m");
            Console.WriteLine($"Player Attack: \u001b[36m{Program.PlayerATK} \u001b[33m | Player Mana: \u001b[36m{Program.PlayerMP}\u001b[33m");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------\n");
        }



        //m8
        public static void PlayerStats(PC Player)
        {
            SpellSchool(Player);
            Console.SetCursorPosition(60, 1);
            Console.Write($"\u001b[32m PLAYER STATS");
            Console.SetCursorPosition(60, 2);
            Console.Write($"\u001b[33m Name: \u001b[36m{Player.Name}\u001b[33m |");
            Console.Write($"\u001b[33m Species: \u001b[36m{Player.ArcSpecies.SpeciesTitle}\u001b[33m |");
            Console.Write($"\u001b[33m Profession: \u001b[36m{Player.ArcJob.JobTitle}\u001b[33m |");
            Console.SetCursorPosition(60, 3);
            Console.Write($"\u001b[33m HP: \u001b[36m{Program.PlayerHp}\u001b[33m |");
            Console.Write($"\u001b[33m MP: \u001b[36m{Program.PlayerMP}\u001b[33m |");
            Console.Write($"\u001b[33m AC: \u001b[36m{Program.PlayerAC}\u001b[33m |");
            Console.Write($"\u001b[33m Atk: \u001b[36m{Program.PlayerATK}\u001b[33m |");
            Console.SetCursorPosition(60, 4);
            Console.Write($"\u001b[33m Magic School 1: \u001b[36m{HUD.SpellSchool1}\u001b[33m |");
            Console.Write($"\u001b[33m Max Spell Level: \u001b[36m{Player.ArcJob.MaxSpellLevel1}\u001b[33m |");
            Console.SetCursorPosition(60, 5);
            Console.Write($"\u001b[33m Magic School 2: \u001b[36m{HUD.SpellSchool2}\u001b[33m |");
            Console.Write($"\u001b[33m Max Spell Level: \u001b[36m{Player.ArcJob.MaxSpellLevel2}\u001b[33m |");
            Console.SetCursorPosition(60, 6);
            Console.Write($"\u001b[33m Level: \u001b[36m{Player.plLevel}\u001b[33m |");
            Console.Write($"\u001b[33m XP: \u001b[36m{Player.plXP}\u001b[33m |");
            //Console.Write($"\u001b[33m AC: \u001b[36m{Program.PlayerAC}\u001b[33m |");
            //Console.Write($"\u001b[33m Atk: \u001b[36m{Program.PlayerATK}\u001b[33m |");
        }

        //m9

        public static void EnemyStats()
        {
            //SpellSchool(Enemy);
            Console.SetCursorPosition(60, 8);
            Console.Write($"\u001b[31m ENEMY STATS");
            Console.SetCursorPosition(60, 9);
            Console.Write($"\u001b[33m Name: \x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
            Console.Write($"\u001b[33m Species: \x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
            Console.Write($"\u001b[33m Profession: \x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
            Console.SetCursorPosition(60, 10);
            Console.Write($"\u001b[33m HP: \x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
            Console.Write($"\u001b[33m MP: \x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
            Console.Write($"\u001b[33m AC: \x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
        }


        //m10
        public static void SetArmor1()
        {
            bool Armor1 = false;
            //Console.WriteLine("Please choose the Armor you would like to ready from the following list:\n 0 = no armor, 1= cloth, 2= leather, 3= chain, 4= plate, all other = default class armor ");
            //Console.ForegroundColor = ConsoleColor.Blue;

            //int SetAr1= Convert.ToInt32(Console.ReadLine());

            //0 = no armor, 1= cloth, 2= leather, 3= chain, 4= plate, all other = default 

            while (!Armor1)
            {

                switch (SetAr1)
                {

                    case 0:
                        armor1Type = Armor.UnArmored;
                        _armor1 = "Unarmored";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have removed your Armor... 'Nekkie, nekkie, eggs and baccie.");
                        Armor1 = true;
                        break;

                    case 1:
                        armor1Type = Armor.wornCloth;
                        _armor1 = "Cloth";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have readied Cloth Armor...' Comefortable and warm...'");
                        Armor1 = true;
                        break;

                    case 2:
                        armor1Type = Armor.wornLeather;
                        _armor1 = "Leather";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have  readied Lether Armor...'Stylish and rugged...'");
                        Armor1 = true;
                        break;

                    case 3:
                        armor1Type = Armor.wornChain;
                        _armor1 = "Chain";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have readied Chain Armor...'Classic protection...'");
                        Armor1 = true;
                        break;

                    case 4:
                        armor1Type = Armor.wornPlate;
                        _armor1 = "Plate";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You have  readied Plate Armor...'Durable and strong, like a crab with a knofe...'");
                        Armor1 = true;
                        break;


                    default:

                        if (HUD.jobType == ArchType.Paladin)
                        {
                            SetAr1 = 4;
                        }
                        else if (HUD.jobType == ArchType.Cleric)
                        {
                            SetAr1 = 3;
                        }
                        else if (HUD.jobType == ArchType.Bard)
                        {
                            SetAr1 = 2;
                        }

                        else if (HUD.jobType == ArchType.Rogue)
                        {
                            SetAr1 = 2;
                        }
                        else if (HUD.jobType == ArchType.Ranger)
                        {
                            SetAr1 = 2;
                        }
                        else if (HUD.jobType == ArchType.Sorcerer)
                        {
                            SetAr1 = 1;
                        }
                        else
                        {
                            SetAr1 = 0;
                        }
                        break;
                }
            }

        }

        //m11

        public static void SpellSchool(PC Player)
        {

            if (Player.ArcJob.MagicType1 == 0)
            {
                SpellSchool1 = "N/A";
            }
            else if (Player.ArcJob.MagicType1 == 1)
            {
                SpellSchool1 = "Elemental";
            }
            else if (Player.ArcJob.MagicType1 == 2)
            {
                SpellSchool1 = "Arcane";
            }
            else if (Player.ArcJob.MagicType1 == 3)
            {
                SpellSchool1 = "Nature";
            }

            else if (Player.ArcJob.MagicType1 == 4)
            {
                SpellSchool1 = "Holy";
            }
            else if (Player.ArcJob.MagicType1 == 5)
            {
                SpellSchool1 = "Healing";
            }
            else if (Player.ArcJob.MagicType1 == 6)
            {
                SpellSchool1 = "Illusion";
            }
            else
            {
                SpellSchool1 = "N/A";
            }

            if (Player.ArcJob.MagicType2 == 0)
            {
                SpellSchool2 = "N/A";
            }
            else if (Player.ArcJob.MagicType2 == 1)
            {
                SpellSchool2 = "Elemental";
            }
            else if (Player.ArcJob.MagicType2 == 2)
            {
                SpellSchool2 = "Arcane";
            }
            else if (Player.ArcJob.MagicType2 == 3)
            {
                SpellSchool2 = "Nature";
            }

            else if (Player.ArcJob.MagicType2 == 4)
            {
                SpellSchool2 = "Holy";
            }
            else if (Player.ArcJob.MagicType2 == 5)
            {
                SpellSchool2 = "Healing";
            }
            else if (Player.ArcJob.MagicType2 == 6)
            {
                SpellSchool2 = "Illusion";
            }
            else
            {
                SpellSchool2 = "N/A";
            }
        }

        //m12

        public static void InfoBlock()
        {
            Console.SetCursorPosition(0, 30);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("|-------------------------------------------------------------- Info Block ---------------------------------------------------------------|");

            Console.SetCursorPosition(0, 31);
            Console.Write($"\u001b[33m You have encountered an enemy would you like to Melee attack 1 Spell attack 2 or defend 3: \x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
            Console.SetCursorPosition(0, 32);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($" 2\u001b[33m ");
            Console.SetCursorPosition(0, 33);
            Console.Write($"\u001b[33m You have chosen spell attack  are you casting a {SpellSchool1} 1 or {SpellSchool2} 2\x1b[38;2;255;165;0mPLACE HOLDER\u001b[33m |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 34);
            Console.Write($"1\u001b[33m |");
            Console.SetCursorPosition(0, 35);
            Console.Write($"\u001b[33m You can cast \x1b[38;2;255;165;125mlevel1 spell Name from selected school\u001b[33m |");

            Console.SetCursorPosition(0, 36);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------------------------------------------+");


        }

        //m13

        public static void CombatOutput()
        {

            Console.SetCursorPosition(60, 12);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("|--------------------- combat output------------------------------------------|");

            Console.SetCursorPosition(60, 13);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            Console.Write($"\u001b[33m You cast selected spell you hit targeted enemy for \x1b[38;2;255;165;0mDamage Value\u001b[33m |");

            Console.SetCursorPosition(60, 14);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($" your attack roll is   attack output  it is .. greater than target enemy AC \u001b[33m ");

            Console.SetCursorPosition(60, 15);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
           // Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\u001b[33m target enemy takes  value amount of damage\x1b[38;2;255;165;0mEnemy counter attacks \u001b[33m |");
            

            Console.SetCursorPosition(60, 16);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");

            Console.Write($"\u001b[33m enemy attack value is less than your AC you take no dmage \u001b[33m |");

            Console.SetCursorPosition(60, 17);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            //Console.Write($"\u001b[33m You can cast \x1b[38;2;255;165;125mlevel1 spell Name from selected school\u001b[33m |");

            Console.SetCursorPosition(60, 18);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("+-----------------------------------------------------------------------------+");
        }

        //m14

        public static void InventoryList()
        {

            Console.SetCursorPosition(60, 20);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("|--------------------- Player Inventory --------------------------------------|");

            Console.SetCursorPosition(60, 21);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            Console.SetCursorPosition(65, 21);
            Console.Write($"\x1b[38;2;255;165;125mArmor 1    |");
            Console.SetCursorPosition(80, 21);
            Console.Write($"\x1b[38;2;255;165;125mArmor 2    |");
            Console.SetCursorPosition(95, 21);
            Console.Write($"\x1b[38;2;255;165;125mWeapon 1    |");
            Console.SetCursorPosition(110, 21);
            Console.Write($"\x1b[38;2;255;165;125mConsumable    |");
            Console.SetCursorPosition(125, 21);
            Console.Write($"\x1b[38;2;255;165;125mKey Item    |");


            Console.SetCursorPosition(60, 22);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write($" your attack roll is   attack output  it is .. greater than target enemy AC \u001b[33m ");

            Console.SetCursorPosition(60, 23);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            //Console.Write($"\u001b[33m target enemy takes  value amount of damage\x1b[38;2;255;165;0mEnemy counter attacks \u001b[33m |");
            //Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(60, 24);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            // Console.Write($"enemy attack value is less than your AC you take no dmage \u001b[33m |");

            Console.SetCursorPosition(60, 25);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            //Console.Write($"\u001b[33m You can cast \x1b[38;2;255;165;125mlevel1 spell Name from selected school\u001b[33m |");

            Console.SetCursorPosition(60, 26);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");

            Console.SetCursorPosition(60, 27);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");

            Console.SetCursorPosition(60, 28);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("+-----------------------------------------------------------------------------+");


        }


        //m15

       public static void ResizeWarning()
        {
            Console.SetCursorPosition(25, 5);
            Console.WriteLine(" hi the console window should be maximized. \n\n           If it is not, please Maximize screen at this time to avoid load errors");
            Console.ReadKey(true);
            Console.Clear();

            Console.SetCursorPosition(25, 7);
            Console.WriteLine("Have you done it yet if yes good for you press a key.. \n\n           if not....\n \n        Shame on a thousand generatins of your family line..........and please maximise screen now. ");
            Console.ReadKey(true);
            Console.Clear();

            Console.SetCursorPosition(25, 11);
            Console.WriteLine("Remember we warned you...");
            Console.ReadKey(true);
            Console.Clear();
        }


        }
}













 