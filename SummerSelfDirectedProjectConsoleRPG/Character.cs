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
    public class Character
    {
        public string _type { get; set; }
        public string Name { get; set; }        
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Dex { get; set; }
        public int BaseAC { get; set; }
        public int BaseHp { get; set; }
        public int BaseAttack { get; set; }
        public int BaseMana { get; set; }
       

        public ConsoleColor _color;
        public char _symbol { get; protected set; }

    
            
        public Character(string type, string name, int strength, int speed, int dex, int baseAC, int baseHp, int baseAtk,int baseMana, char symbol, ConsoleColor color)
        {
            _type = type;
            Name = name;
          
            Strength = strength;
            Speed = speed;
            Dex = dex;
           
            BaseAC = baseAC;
            BaseHp = baseHp;
            BaseAttack = baseAtk;
            BaseMana = baseMana;

            _symbol = symbol;
            _color = color;

       
        }
    } 
}





