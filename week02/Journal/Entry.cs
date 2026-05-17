using System;
public class Entry
{
    public string _date;
    public string _randomPrompt;
    public string _promptEntry;
  
                                                     
    public void Display()
    {
        Console.WriteLine($"Date:    {_date}");
        Console.WriteLine($"Prompt:  {_randomPrompt}");
        Console.WriteLine($"Reply:   {_promptEntry}");
        
    }
}

