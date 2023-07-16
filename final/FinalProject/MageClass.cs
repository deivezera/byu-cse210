using System;

class MageClass : Character
{
    private Dictionary<string,int> _initialAttributes = new Dictionary<string, int>(){
        { "intelligence", 20 },
        { "mana", 50 },
        { "spirit", 8 }
    };
    private List<Skill> _skills;
    public MageClass() : base(){
        _attributes = _initialAttributes;
        _skills = new List<Skill>(){
            new Skill("Fireball", "Launches a fireball at the enemy", 1, 99),
            new Skill("Frost Nova", "Freezes enemies in an area", 1, 99)
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