using System;

public class MathAssignment : Assignment 
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string studentTopic)

    _textbookSection = textbookSection;
    _problems = problems;

    public string GetHomeWorkList()

    {
        return $"Section {textbookSection} Problems{_problems}"
    }
}