using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class GameManager
    {


        //public static List<EnemyLeader> enemiesMap1 = new List<EnemyLeader>();
        //public static List<EnemyLeader> enemiesMap2 = new List<EnemyLeader>();
     
        public static MapLoader map = new MapLoader();
        public static Dictionary<int, List<(int x, int y)>> MapTreasureRegistry = new Dictionary<int, List<(int x, int y)>>();// dictionary set up to track treasure per map to prevent respawn when going back to map after leaving 
        public static Dictionary<int, List<(int x, int y)>> MapCaptiveRegistry = new Dictionary<int, List<(int x, int y)>>();// dictionary set up to track Captives per map to prevent respawn when going back to map after leaving 
        public static Dictionary<int, List<(int x, int y)>> MapOrbRegistry = new Dictionary<int, List<(int x, int y)>>();
        public static Dictionary<int, List<(int x, int y)>> MapPeonRegistry = new Dictionary<int, List<(int x, int y)>>();








        //m1

        public static void Gameon()
            
        {  
            bool isPlaying = true;

            while (isPlaying)
            {



                int plX = 0, plY = 0;
                ConsoleKey input = Console.ReadKey(true).Key;
                // move player with W,A,S,D or optional arrow keys 
                if (input == ConsoleKey.LeftArrow) plX = -1;
                if (input == ConsoleKey.A) plX = -1;
                if (input == ConsoleKey.RightArrow) plX = 1;
                if (input == ConsoleKey.D) plX = 1;
                if (input == ConsoleKey.UpArrow) plY = -1;
                if (input == ConsoleKey.W) plY = -1;
                if (input == ConsoleKey.DownArrow) plY = 1;
                if (input == ConsoleKey.S) plY = 1;

                if (input == ConsoleKey.Q)
                {
                    isPlaying = false; //Quit the 'is playing' loop
                    HUD.Farewell();

                }
            }
        }

    }
}
