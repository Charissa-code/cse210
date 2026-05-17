using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is something you admire about the way someone behaved recently?",
        "If today had a background soundtrack, what songs would be on it and why?",
        "What is something difficult that became easier because you kept showing up?",
        "What conversation do you wish you could revisit and redo?",
        "What is one ordinary thing in you life today that future-you might miss?",
        "What emotion have you been avoiding lately and why?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        return _prompts[number];
    }
}