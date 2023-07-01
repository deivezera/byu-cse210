using System;

public class Checklist : Goal
{
    public int _currentCompleted;
    public int _length;
    public int _bonusPoints;
  
    public override void DisplayGoal()
    {
      string isFinished = _status ? "X" : " ";
      Console.WriteLine($"[{isFinished}] {_name} ({_description}) -- Currently completed:{_currentCompleted}/{_length}");
    }
    public override int AccomplishGoal()
    {
      _currentCompleted = _currentCompleted + 1;
      if(_currentCompleted == _length) {
        _status = true;
        return _points + _bonusPoints;
      } else {
        return _points;
      }
    }
    public override string SaveOnFile()
    {
      return $"{_goalType}:{_name},{_description},{_points},{_bonusPoints},{_length},{_currentCompleted}";
    }
}