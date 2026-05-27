using System.Runtime.CompilerServices;

public class Comment
{
    private string _text;
    private string _commenter;

    public Comment(string commenter, string  text)
    {
        _commenter = commenter;
        _text = text;
    }

    public string CommenterName => _commenter;
    public string CommentText => _text;
}