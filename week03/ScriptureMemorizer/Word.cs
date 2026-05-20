public class Word
{
    //Keeps track of a single word and whether it is shown or hidden.   
    //The key behaviors for the Word class are to hide and show a word and to check if a word is hidden or not. In addition, a Word should have a behavior to get the display text of that word, which would be either the word itself (for example, "prayer") or, if the word were hidden, this behavior would return underscores (for example, "______").

    private string _text;
    private bool _isHidden;
    
    public void Hide();

    public void Show();

    public bool IsHidden();

    public string GetDisplayText();

}