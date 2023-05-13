using System;

class Entry
{
    public string _prompt;
    public string _answer;
    public string _dateTime;

    public Entry(string prompt, string answer, string dateTime)
    {
        _prompt = prompt;
        _answer = answer;
        _dateTime = dateTime;
    }
    public void DisplayEntry()
    {
        Console.WriteLine(_prompt);
        Console.WriteLine($"{_answer} - {_dateTime}");
    }
}