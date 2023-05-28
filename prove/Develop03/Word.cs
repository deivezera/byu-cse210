using System;

class Word
{
    private string _word;
    private Boolean _status;
    
    public Word(string word)
    {
        _word = word;
        _status = false;
    }

    public Boolean getStatus()
    {
        return _status;
    }
    public string getWord()
    {
        if(_status){
            return _word.Replace(_word, new String('-', _word.Length));
        } else {
            return _word;
        }
    }

    public void setWord(bool status)
    {
        _status = status;
    }
}