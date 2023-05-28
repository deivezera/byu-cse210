using System;

class Scripture
{
  private Reference _reference;
  private List<Word> _scripture = new List<Word>();
    
  public Scripture(List<Word> words, Reference reference)
  {
    _reference = reference;
    _scripture = words;
  }

  public void HideWords()
  {
    Random rnd = new Random();
    IEnumerable<Word> randomWords = _scripture.FindAll(x => x.getStatus() == false).OrderBy(x => rnd.Next()).Take(3);
    foreach(Word word in randomWords)
    {
      string data = word.getWord();
      
      word.setWord(true);
    }
  }
  public void ResetWords()
  {
    foreach(Word word in _scripture)
    {
      string data = word.getWord();
      
      word.setWord(false);
    }
  }

  public void DisplayScripture()
  {
    
    string scripReference = _reference.GetReference();
    string phrase = new String("");
    foreach(Word word in _scripture){
      phrase += word.getWord() + " ";
    }
    Console.WriteLine(scripReference + " " + phrase);
  }
}