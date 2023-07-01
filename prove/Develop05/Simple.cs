using System;

public class Simple : Goal
{
    
    public override void DisplayGoal()
    {
      string isFinished = _status ? "X" : " ";
      Console.WriteLine($"[{isFinished}] {_name} ({_description})");
    }
    public override int AccomplishGoal()
    {
      _status = true;
      return _points;
    }
    public override string SaveOnFile()
    {
      return $"{_goalType}:{_name},{_description},{_points},{_status}";
    }
}