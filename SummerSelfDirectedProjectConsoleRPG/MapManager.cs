using SummerSelfDirectedProjectConsoleRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SummerSelfDirectedProjectConsoleRPG
{
    internal class MapManager
    {

//        var newSpawn = map.MapChanger(player._x, player._y); //references the map changer function

//                if (newSpawn.HasValue) //changes maps if triggers are found
//                {
//                    // sets player position to new spawn point 
//                    player._x = newSpawn.Value.x;
//                    player._y = newSpawn.Value.y;
                  
//                }
//    CollectSpawner.SetupMapAssets();
//                Peons.DrawPeon();
//                EnviroHeal.SpringWatterHealling();
//                EnviroDmg.LavaDamage();
//                if (map._mapsCurrent[player._y][player._x] == 'X')
//                {
//                    isPlaying = false;
//                    continue; //skips past rest
//                }

//if (Program.map._currentMapIndex == 0)
//{
//    for (int i = enemiesMap1.Count - 1; i >= 0; i--)
//    {
//        if (enemiesMap1[i]._health <= 0)
//        {
//            Console.Beep(300, 100);
//            Console.Beep(200, 150);
//            Console.SetCursorPosition(enemiesMap1[i]._x, enemiesMap1[i]._y);
//            WriteTileWithColor(map._mapsCurrent[enemiesMap1[i]._y][enemiesMap1[i]._x]);
//            enemiesMap1.RemoveAt(i);
//        }
//        else
//        { EnemyLeader.MoveEnemy(enemiesMap1[i]); }
//    }
//}
//if (Program.map._currentMapIndex == 1)
//{
//    for (int i = enemiesMap2.Count - 1; i >= 0; i--)
//    {
//        if (enemiesMap2[i]._health <= 0)
//        {
//            Console.Beep(300, 100);
//            Console.Beep(200, 150);
//            Console.SetCursorPosition(enemiesMap2[i]._x, enemiesMap2[i]._y);
//            WriteTileWithColor(map._mapsCurrent[enemiesMap2[i]._y][enemiesMap2[i]._x]);
//            enemiesMap2.RemoveAt(i);
//        }
//        else
//        { EnemyLeader.MoveEnemy(enemiesMap2[i]); }
//    }
//}

//if (Program.map._currentMapIndex == 2)
//{
//    for (int i = enemiesMap3.Count - 1; i >= 0; i--)
//    {
//        if (enemiesMap3[i]._health <= 0)
//        {
//            Console.Beep(300, 100);
//            Console.Beep(200, 150);
//            Console.SetCursorPosition(enemiesMap3[i]._x, enemiesMap3[i]._y);
//            WriteTileWithColor(map._mapsCurrent[enemiesMap3[i]._y][enemiesMap3[i]._x]);
//            enemiesMap3.RemoveAt(i);
//        }
//        else
//        { EnemyLeader.MoveEnemy(enemiesMap3[i]); }
//    }
//}

//if (Program.map._currentMapIndex == 3)
//{
//    for (int i = enemyRiderList.Count - 1; i >= 0; i--)
//    {
//        if (enemyRiderList[i]._health <= 0)
//        {
//            Console.Beep(300, 100);
//            Console.Beep(200, 150);
//            Console.SetCursorPosition(enemyRiderList[i]._x, enemyRiderList[i]._y);
//            WriteTileWithColor(map._mapsCurrent[enemyRiderList[i]._y][enemyRiderList[i]._x]);
//            enemyRiderList.RemoveAt(i);
//        }
//        else
//        { EnemyRiders.MoveTowards(enemyRiderList[i]); }
//    }
//}
//DrawEntities();
//Thread.Sleep(20);///
//HUD.plStats();
//            }

//            if ((map._mapsCurrent[player._y][player._x] == 'X') || (player._health == 0))
//{
//    if (player._health == 0)
//    { HUD.plDied(); }
//    if (map._mapsCurrent[player._y][player._x] == 'X')
//    {
//        isPlaying = false;
//        HUD.plWin();
//    }
//}
//HUD.Farewell();
//        }
//        public static void WriteTileWithColor(char tile) //colours the map tiles and writes them to screen
//{
//    if (tile == '%')
//    { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.DarkRed; }
//    else if (tile == 'w')
//    { Console.ForegroundColor = ConsoleColor.DarkCyan; Console.BackgroundColor = ConsoleColor.Blue; }
//    else if (tile == '#')
//    { Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.DarkGray; }
//    else if (tile == ',')
//    { Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Yellow; }
//    else if (tile == '^')
//    { Console.ForegroundColor = ConsoleColor.DarkGreen; Console.BackgroundColor = ConsoleColor.Green; }
//    else if (tile == '[')
//    { Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Gray; }
//    else if (tile == ']')
//    { Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Gray; }
//    else if (tile == 'M')
//    { Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Gray; }
//    else if (tile == '{')
//    { Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.BackgroundColor = ConsoleColor.Magenta; }
//    else if (tile == '}')
//    { Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.BackgroundColor = ConsoleColor.Magenta; }
//    else if (tile == 'X')
//    { Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Gray; }
//    else if (tile == '.')
//    { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.DarkGray; }
//    else if (tile == '`')
//    { Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Yellow; }
//    else Console.ForegroundColor = ConsoleColor.White;

//    Console.Write(tile);
//    Console.ResetColor();
//}
///*>>>>>>*/
//public static void DrawEntities()// draws the player and the enemy symbols/ sprites
//{
//    if (Program.map._currentMapIndex == 0)
//    {
//        foreach (var enmy in enemiesMap1)
//        {
//            if (enmy._health > 0) // Only draw if alive
//            {
//                Console.SetCursorPosition(enmy._x, enmy._y);
//                Console.ForegroundColor = enmy._color;
//                Console.Write(enmy._symbol);
//            }
//        }
//    }

//    if (Program.map._currentMapIndex == 1)
//    {
//        foreach (var enmy in enemiesMap2)
//        {
//            if (enmy._health > 0) // Only draw if alive
//            {
//                Console.SetCursorPosition(enmy._x, enmy._y);
//                Console.ForegroundColor = enmy._color;
//                Console.Write(enmy._symbol);
//            }
//        }
//    }
//    if (Program.map._currentMapIndex == 2)
//    {
//        foreach (var enmy in enemiesMap3)
//        {
//            if (enmy._health > 0) // Only draw if alive
//            {
//                Console.SetCursorPosition(enmy._x, enmy._y);
//                Console.ForegroundColor = enmy._color;
//                Console.Write(enmy._symbol);
//            }
//        }
//    }
//    if (Program.map._currentMapIndex == 3)
//    {
//        MyEvents.AmbushMapCheck();

//    }
//    Console.SetCursorPosition(player._x, player._y);
//    Console.ForegroundColor = player._color;
//    Console.Write(player._symbol);
//    Console.ResetColor();
//    Peons.MovePeonsRandomly();
//}



    }
}
