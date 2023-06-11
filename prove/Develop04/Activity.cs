using System;

public class Activity
{
    protected int _time;
    private string _description;
    private string _activityName;

    public Activity(string description, string activityName)
    {
      _activityName = activityName;
      _description = description;
    }
    public void DisplayMessage() 
    {
      Console.WriteLine($"Welcome to {_activityName} activity.\n");
      Console.WriteLine(_description);
      Spinner spinner = new Spinner();
      spinner.Start();
      Thread.Sleep(2000);
      spinner.Stop();
    }
    public void AskTime()
    {
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string time = Console.ReadLine();
        if(int.TryParse(time, out int value)) {
          _time = int.Parse(time);
        } else {
          Console.WriteLine("The written value is not valid, please write a number.");
        }
    }

    public void FinalInfo()
    {
        Spinner spinner = new Spinner();
        spinner.Start();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_activityName} Activity.");
        Thread.Sleep(5000);
        spinner.Stop();
    }
}