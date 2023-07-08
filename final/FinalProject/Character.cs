using System;

public abstract class Character
{
    private string _nickname;
    private Dictionary<string,int> _attributes;
    private int _level;
    private string _class;

    public Character(string nickname, string cClass)
    {
      _nickname = nickname;
      _class = cClass;
      _level = 1;
    }
    public Character(){}
    static void LevelUpCharacter()
    {
        Console.WriteLine("LevelUp");
    }
    static void ListSkills()
    {
        
    }
    public abstract void ShowInfo();
}