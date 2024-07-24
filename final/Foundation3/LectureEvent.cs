using System;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void GetFullDetails()
    {
        base.GetStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    public void GetShortDetails()
    {
        Console.WriteLine("----Lecture-----");
        Console.WriteLine(_title);
        Console.WriteLine($"Date: {_date}");
    }
}