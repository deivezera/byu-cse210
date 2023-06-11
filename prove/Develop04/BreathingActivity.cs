using System;

class Breathing : Activity
{
    public Breathing(string description, string activityName) : base(description, activityName){}
    public void LoopBreathing()
    {
        int baseBreathe = 5;
        Boolean isBreathing = true;
        Spinner spinner = new Spinner();
        spinner.Start();
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1000);
        spinner.Stop();
        for(int i = _time; i > 0; i--){
            string phrase = isBreathing ? "Breathe in..." : "Now Breathe out...";
            Console.Write($"\r{phrase}{baseBreathe}");
            Thread.Sleep(1000);
            baseBreathe --;
            if(baseBreathe == 0){
                baseBreathe = 5;
                isBreathing = !isBreathing;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Well done!");
    }
}