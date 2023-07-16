using System;

class Player
{
    private string _name;
    private List<Character> _characterList = new List<Character>();
    private Character _selectedCharacter;
    
    public void CreateCharacter()
    {
      Console.WriteLine("Welcome to the RPG Character simulator");
      Console.WriteLine("Let's create a character!");
      ClassSelector classSelector = new ClassSelector();
      string selectedClass = classSelector.Run();
      
      Console.WriteLine("What is going to be your nickname? ");
      string nickname = Console.ReadLine();

      switch (selectedClass)
      {
          case "Warrior":
              _characterList.Add(new WarriorClass {
                _nickname = nickname,
                _class = selectedClass,
              });
              Console.WriteLine("Character created successfully!");
              return;
          case "Archer":
              _characterList.Add(new ArcherClass {
                _nickname = nickname,
                _class = selectedClass,
              });
              Console.WriteLine("Character created successfully!");
              return;
          case "Mage":
              _characterList.Add(new MageClass {
                _nickname = nickname,
                _class = selectedClass,
              });
              Console.WriteLine("Character created successfully!");
              return;
          default:
              Console.WriteLine("Failed to create a character");
              return;
      }

    }
    public void ListCharacters()
    {
      foreach(Character character in _characterList)
      {
        character.ShowInfo();
      }
    }
    public void DeleteCharacter()
    {
      Console.WriteLine("Type the nickname of the character you want to Delete");
      string deleteChar = Console.ReadLine();
      try{
        Character itemRemove = _characterList.Single(c => c._nickname == deleteChar);
        _characterList.Remove(itemRemove);
      }
      catch(System.InvalidOperationException)
      {
        Console.WriteLine("This nickname does not exist");
      }
    }
    public Character SelectCharacter()
    {

      Console.WriteLine("Please, select one character by typing his nickname: ");
      ListCharacters();
      Console.WriteLine();
      string nickname = Console.ReadLine();
      try{
        Character selectedChar = _characterList.Single(c => c._nickname == nickname);
        Console.WriteLine($"You selected {selectedChar._nickname}");
        _selectedCharacter = selectedChar;
        return selectedChar;
      }
      catch(System.InvalidOperationException)
      {
        Console.WriteLine("This nickname does not exist, try again");
        return SelectCharacter();
      }
    }
    public void SimulateGameplay()
    {
      if(_characterList.Count() == 0)
      {
        Console.WriteLine("You don't have a Character created yet, please create a character to play.");
        return;
      }
      Console.WriteLine($"Hello {_name}! Let's start our adventure!");
      Character selectedChar = SelectCharacter();
      
    }
}