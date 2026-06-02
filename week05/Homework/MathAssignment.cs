public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _mathProblems;

    public MathAssignment(string studentName, string topic, string textbookSection, string mathProblems) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _mathProblems = mathProblems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}  Problems {_mathProblems}";
    }
}