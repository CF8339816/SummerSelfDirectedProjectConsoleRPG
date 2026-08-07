public class Character
{
private string _type;

public string Name {get; set;}
public int Hp {get; set;}
public int Speed {get; set;}
public int Dex {get; set;}
public int Ac {get; set;}
public string Magic {get; set;}
public int Strength {get; set;}
public int Attack {get; set;}


public int Mana {get; set;} 
public int XP {get; set;} 


public ConsoleColor _color;
public char _symbol { get; protected set; }


public int ArcType {get; set;}


public int PlHpPerLevBonus {get; set;}
public int Level {get; set;}
public int Mana {get; set;} 
public int XP {get; set;} 
public int ArmorValue {get; set;} 
public int SpellsPerLevel {get; set;}
public string NameUsed {get; set;}



public Character(string type, string name, int hp, int speed, int dex, int ac, string magic, int strength, char symbol, ConsoleColor color, int attack, 
 int mana, string nameUsed, string arcType, int plHpPerLevBonus, int level, int mana, int xp, int armorValue, int spellsPerLevel)
{
_type = type;
Name = name;
Hp = hp;
Speed = speed;
Dex = dex;
Ac = ac;
Magic = magic;
Strength = strength;
Attack = attack;
_symbol = symbol; 
_color = color;

Mana = mana

PlHpPerLevBonus= plHpPerLevBonus;
	ArcType = arcType
	Level = level;
	Mana = mana;
	XP = xp;
	ArmorValue = armorValue;
	SpellsPerLevel = spellsPerLevel;
	NameUsed = nameUsed




}