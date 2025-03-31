using System.Dynamic;

public class MathAssignment : Assignment {
    private double _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, double textBookSection, string problems) : base(studentName, topic)
    {
       _textBookSection = textBookSection;
       _problems = problems;
    }


    public string GetHomeWorkList() 
    {
        return $"TextBook Section: {_textBookSection} - Problem: {_problems}";
    }
}