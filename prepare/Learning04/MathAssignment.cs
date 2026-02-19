public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string text, string problems) : base(name, topic)
    {
        _textbookSection = text;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Textbook Section: {_textbookSection} | Problems: {_problems}";
    }
}