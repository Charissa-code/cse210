using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entriesList = new List<Entry>();

    public void DisplayAll()
     {
        foreach (Entry entry in _entriesList)
            entry.Display();
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file...");
        using StreamWriter output = new StreamWriter(filename);
        {
            foreach (Entry entry in _entriesList)
            {
                output.WriteLine($"{entry._date} | {entry._randomPrompt} | {entry._promptEntry}");
            }
        }
    }

    public void AddEntry(string randomPrompt)
    {
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.WriteLine("My Entry:");
        string promptEntry = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(date, randomPrompt, promptEntry);
        _entriesList.Add(newEntry);
    }

    public void LoadFromFile(string filename)
    {
        _entriesList.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length < 3)
            {
                continue;
            }

            Entry entry = new Entry(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
            _entriesList.Add(entry);
    }
    }
}