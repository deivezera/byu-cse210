using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        
        var menu = 0;
        while(menu != 5){
            menu = journal.DisplayMenu();
            switch (menu)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.Load();
                    break;
                case 4:
                    journal.Save();
                    break;
                case 5:
                    Console.WriteLine("GoodBye!");
                    break;
                default:
                    Console.WriteLine("You picked an invalid option. Choose another one");
                    break;
            }
        }
    }
}