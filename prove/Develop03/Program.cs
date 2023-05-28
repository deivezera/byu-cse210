using System;

class Program
{
    static void Main(string[] args)
    {
        string phrase = "I, Nephi, having been aborn of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";
        string[] splitedWord = phrase.Split(' ');
        List<Word> words = new List<Word>();

        foreach (string item in splitedWord)
        {
            Word word = new Word(item);
            words.Add(word);
        }
        Reference reference = new Reference("1 Nephi", 1, 1, 2);
        Scripture scripture = new Scripture(words, reference);
        string userInput = "";
        Boolean isFirstTimeShowing = false;
        while (userInput != "quit")
        {
            Console.Clear();
            if(userInput == "reset")
            {
                scripture.ResetWords();
                
            } else {
                if(isFirstTimeShowing == false)
                {
                    isFirstTimeShowing = true;
                } else {
                    scripture.HideWords();
                }
            }
            scripture.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue, or type 'reset' to reveal the words again, or 'quit' to continue: ");
            userInput = Console.ReadLine();
        }
    }
}