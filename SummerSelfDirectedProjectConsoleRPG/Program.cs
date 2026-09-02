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
using static SummerSelfDirectedProjectConsoleRPG.ElementalSpells;
using static SummerSelfDirectedProjectConsoleRPG.ArcaneSpells;
using static SummerSelfDirectedProjectConsoleRPG.HolySpells;
using static SummerSelfDirectedProjectConsoleRPG.HealingSpells;
using static SummerSelfDirectedProjectConsoleRPG.NatureSpells;
using static SummerSelfDirectedProjectConsoleRPG.IllusionSpells;
using static SummerSelfDirectedProjectConsoleRPG.Program;


namespace SummerSelfDirectedProjectConsoleRPG
{

    class Program
    {
       
        public static int PlayerHp;
        public static int PlayerAC;
        public static int PlayerATK;
        public static int PlayerMP;
        public static int MagicACBonus;
        public static int MaxNameLLength = 15;
        public ArchType _ArchType = HUD.jobType;
        public ArchSpecies _ArchSpecies = HUD.SpeciesChoice;


       // public static bool isPlaying = true;


        static void Main()
        {
            HUD.ChooseMyClass();
            HUD.ChooseMySpecies();
            HUD.NameMyCharacter();

            PC Player = new PC("Player", HUD.nameChoice, 11, 11, 11, 10, 7, 2, 12, '&', ConsoleColor.Blue,  HUD.jobType, HUD.SpeciesChoice, Program.PlayerHp, Program.PlayerAC, 1, 0);
             
            PlayerHp = Player.BaseHp + Player.PcHp + HUD.jobType.AtHp + HUD.SpeciesChoice.HpBonusSpecies;
            PlayerAC = HUD.SpeciesChoice.ACbonusSpecies + HUD.jobType.ArmorBonus + MagicACBonus;
            PlayerATK = HUD.jobType.AttackBonus + Player.BaseAttack;
            PlayerMP = HUD.jobType.ManaBonus + HUD.SpeciesChoice.ManaBonusSpecies + Player.BaseMana;

            Console.Clear();

            HUD.PcCreatinConfirmation(Player);

            Console.ReadKey(true);
            Console.Clear();
            HUD.Instructions();
            Console.ReadKey(true);
            GameManager.Gameon();

            //while (isPlaying)
            //{



            //    int plX = 0, plY = 0;
            //    ConsoleKey input = Console.ReadKey(true).Key;
            //    // move player with W,A,S,D or optional arrow keys 
            //    if (input == ConsoleKey.LeftArrow) plX = -1;
            //    if (input == ConsoleKey.A) plX = -1;
            //    if (input == ConsoleKey.RightArrow) plX = 1;
            //    if (input == ConsoleKey.D) plX = 1;
            //    if (input == ConsoleKey.UpArrow) plY = -1;
            //    if (input == ConsoleKey.W) plY = -1;
            //    if (input == ConsoleKey.DownArrow) plY = 1;
            //    if (input == ConsoleKey.S) plY = 1;

            //    if (input == ConsoleKey.Q)
            //    {
            //        isPlaying = false; //Quit the 'is playing' loop
            //        HUD.Farewell();

            //    }
            //}

        }

    }
}




//public static Player player = new Player(" ", 3, 3, plaAtkUP, '!', plaMaxHP, ConsoleColor.Blue, (1, 55), (1, 24));
//public static List<EnemyLeader> enemiesMap1 = new List<EnemyLeader>();
//public static List<EnemyLeader> enemiesMap2 = new List<EnemyLeader>();
//public static List<EnemyLeader> enemiesMap3 = new List<EnemyLeader>();
//public static List<EnemyRiders> enemyRiderList = new List<EnemyRiders>();
//public static LoadMap map = new LoadMap();
//public static Dictionary<int, List<(int x, int y)>> MapTreasureRegistry = new Dictionary<int, List<(int x, int y)>>();// dictionary set up to track treasure per map to prevent respawn when going back to map after leaving 
//public static Dictionary<int, List<(int x, int y)>> MapCaptiveRegistry = new Dictionary<int, List<(int x, int y)>>();// dictionary set up to track Captives per map to prevent respawn when going back to map after leaving 
//public static Dictionary<int, List<(int x, int y)>> MapOrbRegistry = new Dictionary<int, List<(int x, int y)>>();
//public static Dictionary<int, List<(int x, int y)>> MapPeonRegistry = new Dictionary<int, List<(int x, int y)>>();
//public static bool isPlaying = true;

//public static bool isAlly = false; //sets bool to check for other allies in movement path


//        HUD.Instructions();



//        int plX = 0, plY = 0;
//ConsoleKey input = Console.ReadKey(true).Key;
//        // move player with W,A,S,D or optional arrow keys 
//        if (input == ConsoleKey.LeftArrow) plX = -1;
//        if (input == ConsoleKey.A) plX = -1;
//        if (input == ConsoleKey.RightArrow) plX = 1;
//        if (input == ConsoleKey.D) plX = 1;
//        if (input == ConsoleKey.UpArrow) plY = -1;
//        if (input == ConsoleKey.W) plY = -1;
//        if (input == ConsoleKey.DownArrow) plY = 1;
//        if (input == ConsoleKey.S) plY = 1;

//        if (input == ConsoleKey.Q) isPlaying = false; //Quit the 'is playing' loop
//        HUD.ClearMessage();
//        player.Move(plX, plY);
//        Treasure.CheckTreasureCollection();
//        Captive.CheckCapCollection();
//        PowerOrb.CheckOrbCollection();
//        Peons.CheckPeonCollection(); 