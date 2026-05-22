

public class Reference
{
    private string _book;          
    private int _chapter;           
    private int _verse;            
    private int _lastVerse;         


    public Reference(string book, int chapter, int verse)
    { 
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = lastVerse;
    }

    public string GetDisplayText()
    {
        if (_lastVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_lastVerse}";
        }

        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
  

}