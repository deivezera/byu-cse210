public class Skill
{
    public string _name { get; set; }
    public string _description { get; set; }
    public int _requiredAttributeLevel { get; set; }
    public int _maxLevel { get; set; }
    public int _currentLevel { get; set; }

    public Skill(string name, string description, int requiredAttributeLevel, int maxLevel)
    {
        _name = name;
        _description = description;
        _requiredAttributeLevel = requiredAttributeLevel;
        _maxLevel = maxLevel;
        _currentLevel = 0;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{_name} - {_currentLevel}lv");
        Console.WriteLine($"{_description}");
    }

    public void LevelUp()
    {
        if (_currentLevel < _maxLevel)
        {
            _currentLevel++;
        }
    }

    public void Reset()
    {
        _currentLevel = 0;
    }
}
