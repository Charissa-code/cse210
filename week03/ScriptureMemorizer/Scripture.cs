using System.Collections.Generic;
public class Scripture
{

    private List<Word> _wordsList;                  //just like _entriesList in Journal
    private Reference _reference;               //same type as class above           

    private string _originalText;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _originalText = text;
        _wordsList = new List<Word>();
        foreach (string word in text.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
            _wordsList.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> availableWords = new List<Word>();

        foreach (Word word in _wordsList)
        {
            if (!word.IsHidden())
            {
                availableWords.Add(word);
            }
        }

        if (availableWords.Count < numberToHide)
        {
            numberToHide = availableWords.Count;
        }
      
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index);
        }
    }


    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (Word word in _wordsList)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordsList)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public string GetOriginalText()
    {
        return _reference.GetDisplayText() + " " + _originalText;
    }   
}

