using System;
using static System.Environment;
class Journal
{
  public List<Entry> _entriesList = new List<Entry>();

  public int DisplayMenu()
    {
        int menu = 0;
        
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");

        menu = int.Parse(Console.ReadLine());
        if(String.IsNullOrEmpty(menu.ToString())) {
            Console.WriteLine("Invalid option. Try again!");
            return 0;
        }
        return menu;
    }
    public void DisplayJournal()
    {
        foreach(var entry in _entriesList){
            string answer = entry._answer;
            string dateTime = entry._dateTime;

            Console.WriteLine($"{answer} - {dateTime}{NewLine}" );
        }
    }
    public void Save()
    {
        Console.WriteLine("Write the name of the file you want to save your journal");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName + ".txt"))
        {
            // You can add text to the file with the WriteLine method
            foreach(var entry in _entriesList){
                outputFile.WriteLine($"{entry._prompt}~{entry._answer}~{entry._dateTime}");
            }
        }
    }
    public void Load()
    {
        _entriesList.Clear();
        Console.WriteLine("Write the name of the file you want to load your journal");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName + ".txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string promptText = parts[0];
            string answer = parts[1];
            string dateTime = parts[2];
            Entry entry = new Entry(promptText,  answer, DateTime.Now.ToShortDateString());
            _entriesList.Add(entry);
        }
    }
    public void WriteNewEntry()
    {
        Prompt prompt = new Prompt();
        string promptText = prompt.GetRandomPrompt();
        Console.WriteLine(promptText);
        string answer = Console.ReadLine();

        if(String.IsNullOrEmpty(answer)){
            Console.WriteLine("Invalid answer, try again.");
            return;
        }
        Entry entry = new Entry(promptText,  answer, DateTime.Now.ToShortDateString());
        _entriesList.Add(entry);
    }
}