using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.ArchSpecies;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;
using static SummerSelfDirectedProjectConsoleRPG.PC;

namespace SummerSelfDirectedProjectConsoleRPG
{

	class Program
	{
		public string nameUsed;
		
        public string Job;
        public string Species;
        public static int PlayerHp;
        public static int PlayerAC;
        public static int MagicACBonus;
        public static int MaxNameLLength = 15;



        public static bool isPlaying = true;

        //public ArchType ArchType(" ", 5, 50, " ", 3, 0, "Holy", "N/A", 13, "Plate", 5)



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

        // ArchType(" ", 5, 50, " ", 3, 0, "Holy", "N/A", 13, "Plate", 5)
        static void Main()
		{
            HUD.ChooseMyClass();
			HUD.NameMyCharacter();
            PlayerHp = Character.hp + PC.PcHp + ArchType.AtHp;
            PlayerAC = ArchSpecies.ACbonusSpecies + ArchType.ArmorBonus + MagicACBonus;
            PC.name = nameUsed;
            PC.maxAC =PlayerAC;
            PC.maxHP =PlayerHp; 






            while (isPlaying)
            {
                //        HUD.Instructions();
                //        player._name =Name;
                //        player._attack =plaAtkUP;
                //       PC.profession = arcJob;



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









            }

        }
        
        



	}
}