using System;

class Reflection : Activity
{

    private List<string> _prompts = new List<string>(){
        "Think of a time when you did something really difficult",
    };
    private List<string> _questions = new List<string>(){
        "How did you feel when it was completed?",
        "What was the favorite thing about this experience"
    };
    public Reflection(string description, string activityName) : base(description, activityName){}

    public void DoReflection()
    {
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1000);
        Random r = new Random();
        int index = r.Next( _prompts.Count );
        string randomString = _prompts[ index ];
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {randomString} ---");
        for(int i = 0; i < _questions.Count; i++){
            Console.WriteLine();
            for(int j = _time/_questions.Count; j > 0; j--){
                Spinner spinner = new Spinner(text: _questions[i]);
                spinner.Start();
                Thread.Sleep(1000);
                spinner.Stop();
            }
        }
    }
}