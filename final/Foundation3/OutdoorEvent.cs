using System;

public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public void GetFullDetails()
    {
        base.GetStandardDetails();
        Console.WriteLine($"The forecasted weather is {_weather}, please plan accordingly.");
    }

    public void GetShortDetails()
    {
        Console.WriteLine("----Outdoors Event-----");
        Console.WriteLine(_title);
        Console.WriteLine($"Date: {_date}");
    }
}