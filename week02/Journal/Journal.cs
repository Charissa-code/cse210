using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _date = "";
    public string _randomPrompt = "";
    public string _promptEntry = "";
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

    public void AddEntry(Entry newEntry)
    {
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

            Entry entry = new Entry
            {
                _date = parts[0],
                _randomPrompt = parts[1],
                _promptEntry = parts[2]
            };
            _entriesList.Add(entry);
    }
    }
}