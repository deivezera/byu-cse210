using System;

public class Eternal : Goal
{
    public override void DisplayGoal()
    {
      Console.WriteLine($"[ ] {_name} ({_description})");
    }
    public override int AccomplishGoal()
    {
      return _points;
    }
    public override string SaveOnFile()
    {
      return $"{_goalType}:{_name},{_description},{_points}";
    }
}
