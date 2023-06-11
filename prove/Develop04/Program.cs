using System;

class Program
{
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
        Console.Clear();
        Console.WriteLine("Menu options:");
        Console.WriteLine("1) Start breathing activity");
        Console.WriteLine("2) Start reflecting activity");
        Console.WriteLine("3) Start listing activity");
        Console.WriteLine("4) Quit");

        Console.Write("\r\nSelect a choice from the menu: ");
    
        switch (Console.ReadLine())
        {
            case "1":
                Breathing breathingActivity = new Breathing(
                    "This activity should help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 
                    "Breathing"
                );
                breathingActivity.DisplayMessage();
                breathingActivity.AskTime();
                breathingActivity.LoopBreathing();
                breathingActivity.FinalInfo();
                return true;
            case "2":
                Reflection reflectionActivity = new Reflection(
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    "Reflection"
                );
                reflectionActivity.DisplayMessage();
                reflectionActivity.AskTime();
                reflectionActivity.DoReflection();
                reflectionActivity.FinalInfo();
                return true;
            case "3":
                Listing listingActivity = new Listing(
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    "Listing"
                );
                listingActivity.DisplayMessage();
                listingActivity.AskTime();
                listingActivity.DoListing();
                listingActivity.FinalInfo();
                return true;
            case "4":
                return false;
            default:
                return true;
        }
    }
}