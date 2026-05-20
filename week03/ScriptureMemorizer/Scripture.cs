using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Scripture
{
                //Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
                //The key behaviors for the Scripture class are to hide random words and also to get the display text as a string. (The "display text" refers to the text with some words shown normally, and some replaced by underscores.) It would also be nice to have a behavior to check if the scripture is completely hidden so that you know when to end the program.

    private int _numberToHide;
    private object _words; //: List<Word>
    private _reference;  // :Reference


    private List<Word> words = new List<Word>;
    

    public void HideRandomWords(int NumberToHide);
    {
        //possibly use methods...
        public void Hide();
        public void Show();
        public bool IsHidden();

    }


    public string GetDisplayText(); //a string combining the book, chapter and verse or verses.

    public bool IsCompletelyHidden();

}