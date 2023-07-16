using System;

class WarriorClass : Character
{
    private Dictionary<string,int> _initialAttributes = new Dictionary<string, int>(){
        { "strength", 15},
        { "defense", 10 },
        { "agility", 5 }
    };
    private List<Skill> _skills;

    public WarriorClass() : base(){
        _attributes = _initialAttributes;
        _skills = new List<Skill>(){
            new Skill("Slash","A powerful melee attack", 1, 99),
            new Skill("Berserk","Increases damage output temporarily", 1, 99)
        };
        _level = 1;
    }
    public override void LevelUpCharacter(){
        _level = _level + 1;
    }
    public override void ListSkills(){
        foreach(Skill skills in _skills)
        {
            skills.DisplayInfo();
        }
    }
    public override void ShowInfo() {
        Console.WriteLine($"{_nickname} - {_class} - {_level}");
    }
}