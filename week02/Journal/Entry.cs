using System;

public class Entry
{
    public string _date;
    public string _randomPrompt;
    public string _promptEntry;

    public Entry(string date, string randomPrompt, string promptEntry)
    {
        _date = date;
        _randomPrompt = randomPrompt;
        _promptEntry = promptEntry;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_randomPrompt}");
        Console.WriteLine($"Entry: {_promptEntry}");
    }
}
  