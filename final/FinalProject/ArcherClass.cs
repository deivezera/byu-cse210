using System;

class ArcherClass : Character
{
    private Dictionary<string,int> _initialAttributes = new Dictionary<string, int>() {
        { "agility", 12 },
        { "accuracy", 15 },
        { "critical", 10 }
    };
    private List<Skill> _skills;

    public ArcherClass() : base(){
        _attributes = _initialAttributes;
        _skills = new List<Skill>(){
            new Skill("Shoot", "A ranged attack with a bow", 1, 99),
            new Skill("Piercing Shot", "Deals high damage and ignores enemy defense", 1, 99)
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