


public class Video

{
    private string _title;
    private string _author;
    private int _lenInSecs;

    private List<Comment> _commentsList = new List<Comment>();

    public Video(string title, string author, int lenInSecs)
    {
        _title = title;
        _author = author;
        _lenInSecs = lenInSecs;
    }

       public string Title => _title;

    public string Author => _author;

    public int LenInSecs => _lenInSecs;

    public void AddComment(Comment comment)
    {
        _commentsList.Add(comment);
    }

    public int Comments()
    {
        return _commentsList.Count;
    }

    public List<Comment> GetComments()
    {
        return _commentsList;
    }

}