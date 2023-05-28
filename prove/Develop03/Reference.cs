using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int? _lastVerse;

    public Reference(string book, int chapter, int firstVerse)
    {
      _book = book;
      _chapter = chapter;
      _firstVerse = firstVerse;
      _lastVerse = null;
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
      _book = book;
      _chapter = chapter;
      _firstVerse = firstVerse;
      _lastVerse = lastVerse;
    }

    public string GetReference()
    {
      if(_lastVerse == null){
        return $"{_book} {_chapter.ToString()}:{_firstVerse.ToString()}";
      } else {
        return $"{_book} {_chapter.ToString()}:{_firstVerse.ToString()}-{_lastVerse.ToString()}";
      }
    }

}