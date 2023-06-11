using System;

class Listing : Activity
{

    private List<string> _prompts = new List<string>(){
        "When have you felt the Holy Ghost this month?",
    };
    private List<string> _listing = new List<string>();
    public Listing(string description, string activityName) : base(description, activityName){}

    public void DoListing()
    {
        int setupTime = 5;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time + setupTime);
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1000);
        Random r = new Random();
        int index = r.Next( _prompts.Count );
        string randomString = _prompts[ index ];
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {randomString} ---");
        for(int i = setupTime-1; i > 0; i--)
        {
            Console.Write($"\rYou may begin in: {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        while(DateTime.Now < futureTime)
        {
            Console.Write("> ");
            _listing.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_listing.Count} items");
        
    }
}