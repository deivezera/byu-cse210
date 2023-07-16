using System;

public abstract class Character
{
    public string _nickname;
    public Dictionary<string,int> _attributes;
    public int _level;
    public string _class;

    public Character(string nickname, string cClass)
    {
      _nickname = nickname;
      _class = cClass;
    }
    public Character(){}
    public abstract void LevelUpCharacter();
    public abstract void ListSkills();
    public abstract void ShowInfo();
}