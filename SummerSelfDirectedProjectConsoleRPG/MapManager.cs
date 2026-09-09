using SummerSelfDirectedProjectConsoleRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using static SummerSelfDirectedProjectConsoleRPG.MapLoader;

namespace SummerSelfDirectedProjectConsoleRPG
{
   public class MapManager
    {


        public static MapLoader map = new MapLoader();

        public static bool isAlly = false; //sets bool to check for other allies in movement path
        public static bool IsTileOccupied(int x, int y)
        {
            // moved the  tile check here  to see if it would stop the treasure and  captive spawns in the lava
            int currentMap = map._currentMapIndex;// checks using info from current map
            char targetTile = map._mapsCurrent[y][x];
            char[] forbiddenTiles = { '#', 'w', '%', '|', 'M', '-', '+', 'S', '$', '&', '6', 'O', 'H', '@', '!', '*' };
            if (Array.Exists(forbiddenTiles, t => t == targetTile))
            { return true; }
            // Check if player  is there
            //if (x == Program.player._x && y == Program.player._y)
            //{ return true; }
            //// check for enemmies
            //if (Program.enemiesMap1.Any(enmy => enmy._x == x && enmy._y == y))
            //{ return true; }
            //if (Program.enemiesMap2.Any(enmy => enmy._x == x && enmy._y == y))
            //{ return true; }
            //if (Program.enemiesMap3.Any(enmy => enmy._x == x && enmy._y == y))
            //{ return true; }
            //if (Program.enemyRiderList.Any(enmy => enmy._x == x && enmy._y == y))
            //{ return true; }
           // // Check for gold spawn using current map's dictionary list
            //if (Program.MapTreasureRegistry.ContainsKey(currentMap))
            //{
            //    if (Program.MapTreasureRegistry[currentMap].Any(g => g.x == x && g.y == y))/// checks positions from dictionary for current map
            //    { return true; }
            //}

            //if (Program.MapOrbRegistry.ContainsKey(currentMap))
            //{
            //    if (Program.MapOrbRegistry[currentMap].Any(g => g.x == x && g.y == y))/// checks positions from dictionary for current map
            //    { return true; }
            //}

            //if (Program.MapPeonRegistry.ContainsKey(currentMap))
            //{
            //    if (Program.MapPeonRegistry[currentMap].Any(p => p.x == x && p.y == y))
            //    { return true; }
            //}
            //// Check there is already a captive there using current dictionary list for current map
            //if (Program.MapCaptiveRegistry.ContainsKey(currentMap))
            //{
            //    if (Program.MapCaptiveRegistry[currentMap].Any(p => p.x == x && p.y == y))
            //    { return true; }
            //}
            return false;
        }





    }
}
