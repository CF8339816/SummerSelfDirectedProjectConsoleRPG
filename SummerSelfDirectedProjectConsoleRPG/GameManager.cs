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


        public static bool isAlly = false; //sets bool to check for other allies in movement path
        //public static bool IsTileOccupied(int x, int y)
        //{
        //    // moved the  tile check here  to see if it would stop the treasure and  captive spawns in the lava
        //    int currentMap = MapManager.map._currentMapIndex;// checks using info from current map
        //    char targetTile = MapManager.map._mapsCurrent[y][x];
        //    char[] forbiddenTiles = { '#', 'w', '%', '|', 'M', '-', '+', 'S', '$', '&', '6', 'O', 'H', '@', '!', '*' };
        //    if (Array.Exists(forbiddenTiles, t => t == targetTile))
        //    { return true; }
        //    // Check if player  is there
        //    if (x == Program.Player._x && y == Program.Player._y)
        //    { return true; }
        //    // check for enemmies
        //    if (Program.enemiesMap1.Any(enmy => enmy._x == x && enmy._y == y))
        //    { return true; }
        //    if (Program.enemiesMap2.Any(enmy => enmy._x == x && enmy._y == y))
        //    { return true; }
        //    if (Program.enemiesMap3.Any(enmy => enmy._x == x && enmy._y == y))
        //    { return true; }
        //    if (Program.enemyRiderList.Any(enmy => enmy._x == x && enmy._y == y))
        //    { return true; }
        //    // Check for gold spawn using current map's dictionary list
        //    if (Program.MapTreasureRegistry.ContainsKey(currentMap))
        //    {
        //        if (Program.MapTreasureRegistry[currentMap].Any(g => g.x == x && g.y == y))/// checks positions from dictionary for current map
        //        { return true; }
        //    }

        //    if (Program.MapOrbRegistry.ContainsKey(currentMap))
        //    {
        //        if (Program.MapOrbRegistry[currentMap].Any(g => g.x == x && g.y == y))/// checks positions from dictionary for current map
        //        { return true; }
        //    }

        //    if (Program.MapPeonRegistry.ContainsKey(currentMap))
        //    {
        //        if (Program.MapPeonRegistry[currentMap].Any(p => p.x == x && p.y == y))
        //        { return true; }
        //    }
        //    // Check there is already a captive there using current dictionary list for current map
        //    if (Program.MapCaptiveRegistry.ContainsKey(currentMap))
        //    {
        //        if (Program.MapCaptiveRegistry[currentMap].Any(p => p.x == x && p.y == y))
        //        { return true; }
        //    }
        //    return false;
        //}





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
