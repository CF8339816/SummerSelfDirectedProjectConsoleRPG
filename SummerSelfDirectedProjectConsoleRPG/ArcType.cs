using SummerSelfDirectedProjectConsoleRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static SummerSelfDirectedProjectConsoleRPG.ArchType;

namespace SummerSelfDirectedProjectConsoleRPG
{
    public class ArchType
    {

        public string PlayerClass;

        public string arcType;

        public string CharacterRole;


public enum CharRole
        {
            Paladin = 1,
            Bard,
            Cleric,
            Rogue,
            Ranger,
            Sorcerer
        }
    }
}


public void (ChooseMyClass)
    {
    Console.WriteLine {"Please choose a character class from the following list: 1) Paladon 2) Bard, 3) Cleric, 4) Rogue, 5) Ranger, 6) Sorcerer."};
    Console.ReadLine();

    switch (CharacterRole)
    {
        case CharRole.Paladin:
            arcType = Paladin;
            Console.WriteLine("You have chosen to be a Paladin, 'Stalward and true... With great power comes...SMITE!!!!!'");
            break;

        case CharRole.Bard:
            arcType = Bard;
            Console.WriteLine("You have chosen to be a Bard, 'I'm not the problem.... the story this would make is the problem...'");
            break;
        
        case CharRole.Cleric:
            arcType = Cleric;
            Console.WriteLine("You have chosen to be a Cleric, 'Oh Lawd give me the strngth to heal these nitwits....'");
            break;
       
        case CharRole.Rogue:
            arcType = Rogue;
            Console.WriteLine("You have chosen to be a Rogue , 'Sneaky, sneaky  Suggah...'");
            break;
       
        case CharRole.Ranger:
            arcType = Ranger;
            Console.WriteLine("You have chosen to be a Ranger, 'What do you see with your Elvish Eyes.'");
            break;
        
        case CharRole.Sorcerer
            arcType = Sorcerer

            Console.WriteLine("You have chosen to be a Sorcerer, 'Phenomional Cosmic Power...About to be sued by Disney...'");
            break;
    }
}


