using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.ArcaneSpells;
using static SummerSelfDirectedProjectConsoleRPG.ArchSpecies;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;
using static SummerSelfDirectedProjectConsoleRPG.ElementalSpells;
using static SummerSelfDirectedProjectConsoleRPG.HealingSpells;
using static SummerSelfDirectedProjectConsoleRPG.HolySpells;
using static SummerSelfDirectedProjectConsoleRPG.IllusionSpells;
using static SummerSelfDirectedProjectConsoleRPG.MapLoader;
using static SummerSelfDirectedProjectConsoleRPG.NatureSpells;
using static SummerSelfDirectedProjectConsoleRPG.PC;
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

        //  public static MapLoader map = new MapLoader();

        #region forced Maximize Startup
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow); //Define the 'Maximize' command constant

  
        private const int SW_RESTORE = 9;   // Unlocks the layout constraints
        private const int SW_MAXIMIZE = 3;
        #endregion

        static void Main()
        {

            #region Startup Maxixization
            Thread.Sleep(50);//does a little delay on startup to process the screen resize
            IntPtr handle = GetForegroundWindow();
            if (handle != IntPtr.Zero)
            {
                ShowWindow(handle, SW_RESTORE);
                ShowWindow(handle, SW_MAXIMIZE);
            }

            #endregion

           
            HUD.ResizeWarning();

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
           MapManager.map.DrawMap();
            HUD.PlayerStats(Player);
            HUD.EnemyStats();
            HUD.CombatOutput();
            HUD.InventoryList();
            HUD.InfoBlock();
            HUD.Instructions();
            Console.ReadKey(true);
           

            GameManager.Gameon();

           


       

        }

    }
}



