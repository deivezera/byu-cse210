using System;

class Player
{
    private string _name;
    private List<Character> _characterList;
    
    public void CreateCharacter()
    {
      Console.WriteLine("Welcome to the RPG Character simulator");
      Console.WriteLine("Let's create a character!");
      ClassSelector classSelector = new ClassSelector();
      string selectedClass = classSelector.Run();
      
      Console.WriteLine("What is going to be your nickname? ");
      string nickname = Console.ReadLine();

    }
    public void ListCharacters()
    {
      
    }
    public void DeleteCharacter()
    {
      
    }
    public void SelectCharacter()
    {
      
    }
    public void SimulateGameplay()
    {

    }
}