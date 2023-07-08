using System;

class ClassSelector
{
    private List<string> _availableClasses = new List<string>(){
      "Warrior",
      "Mage",
      "Archer"
    };
    public string Run()
    {
      string selectedClass = SelectClasses();
      if(_availableClasses.Contains(selectedClass)){
        return selectedClass;
      } else {
        return SelectClasses();
      }
    } 
    private string SelectClasses()
    {
        Console.WriteLine();
        Console.WriteLine("Which class will you play?");
        ShowClasses();
        string selectedClass = Console.ReadLine();
        return selectedClass;
    }
    private void ShowClasses()
    {
        foreach(string item in _availableClasses)
        {
          Console.WriteLine($"- {item}");
        }
    }
}