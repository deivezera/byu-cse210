using System;

public abstract class Goal
{
    public string _goalType;
    public string _name;
    public string _description;
    public int _points;
    public bool _status;

    public abstract void DisplayGoal();
    public abstract int AccomplishGoal();
    public abstract string SaveOnFile();
}