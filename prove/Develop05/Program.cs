using System;
using System.IO; 
class Program
{
    public static List<Goal> _goals = new List<Goal>();
    public static int _totalPoints = 0;
    static void Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }
    static Boolean MainMenu()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine();
        Console.WriteLine("Menu options:");
        Console.WriteLine("1) Create New Goal");
        Console.WriteLine("2) List Goals");
        Console.WriteLine("3) Save Goals");
        Console.WriteLine("4) Load Goals");
        Console.WriteLine("5) Record Event");
        Console.WriteLine("6) Quit");

        Console.Write("\r\nSelect a choice from the menu: ");
    
        switch (Console.ReadLine())
        {
            case "1":
                bool showCreateGoalOptions = true;
                while (showCreateGoalOptions)
                {
                    showCreateGoalOptions = CreateGoal();
                }
                return true;
            case "2":
                ListGoals();
                return true;
            case "3":
                SaveGoals();
                return true;
            case "4":
                LoadGoals();
                return true;
            case "5":
                RecordEvent();
                return true;
            case "6":
                return false;
            default:
                return true;
        }
    }
    static bool CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goals");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Checklist Goals");
        Console.WriteLine("Which type of goal would you like to create?");
        string type = Console.ReadLine();
        Console.WriteLine("What's the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What's a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What's the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        switch (type)
        {
            case "1":
                _goals.Add(new Simple {
                    _name = name, 
                    _description = description, 
                    _goalType = "SimpleGoal", 
                    _points = points, 
                    _status = false
                });
                return false;
            case "2":
                _goals.Add(new Eternal {
                    _name = name, 
                    _description = description, 
                    _goalType = "EternalGoal", 
                    _points = points, 
                    _status = false
                });
                return false;
            case "3":
                Console.WriteLine("How many times does this goal needs to be accomplished for a bonus? ");
                int times = int.Parse(Console.ReadLine());
                Console.WriteLine("What's the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new Checklist {
                    _name = name, 
                    _description = description, 
                    _goalType = "ChecklistGoal", 
                    _points = points,
                    _status = false, 
                    _bonusPoints = bonusPoints, 
                    _length = times, 
                    _currentCompleted = 0
                });
                return false;
            default:
                return true;
        }
    }
    static void ListGoals()
    {
        foreach (Goal elem in _goals)
        {
            elem.DisplayGoal();
        }
    }
    static void SaveGoals()
    {
        Console.WriteLine("What's the filename for your goals?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{_totalPoints}");
            
            foreach (Goal elem in _goals)
            {
                outputFile.WriteLine($"{elem.SaveOnFile()}");
            }
        }
    }
    static void LoadGoals()
    {   
        Console.WriteLine("What's the filename for the goal file?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            if(parts.Count() == 1){
                _totalPoints = int.Parse(parts[0]);
            } else {

                string goalType = parts[0];
                string goalInfo = parts[1];
                string[] info = goalInfo.Split(",");
                string name = info[0];
                string description = info[1];
                string points = info[2];
                if(goalType == "SimpleGoal"){
                    string status = info[3];
                    _goals.Add(new Simple {
                        _name = name, 
                        _description = description, 
                        _goalType = "SimpleGoal", 
                        _points = int.Parse(points), 
                        _status = bool.Parse(status)
                    });
                } else if (goalType == "EternalGoal") {
                        _goals.Add(new Eternal {
                        _name = name, 
                        _description = description, 
                        _goalType = "EternalGoal", 
                        _points = int.Parse(points), 
                        _status = false
                    });
                } else {
                    string bonusPoints = info[3];
                    string times = info[4];
                    string currentCompleted = info[5];
                    _goals.Add(new Checklist {
                        _name = name, 
                        _description = description, 
                        _goalType = "ChecklistGoal", 
                        _points = int.Parse(points),
                        _status = false, 
                        _bonusPoints = int.Parse(bonusPoints), 
                        _length = int.Parse(times), 
                        _currentCompleted = int.Parse(currentCompleted)
                    });
                }
            }
            
        }
    }
    static void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) 
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }
        Console.WriteLine("Which goal did accomplish?");
        int goalAccomplished = int.Parse(Console.ReadLine());
        int pointsReceived = _goals[goalAccomplished - 1].AccomplishGoal();
        _totalPoints = _totalPoints + pointsReceived;
        Console.WriteLine($"Congratulations! You have earned {pointsReceived}");
        Console.WriteLine($"You now have {_totalPoints}");
    }
}