using System;

public class Assignment
{
    string _studentName = "";
    string _topic="";

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Name: {_studentName} Topic: {_topic}";
    }

}