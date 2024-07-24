using System;

public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void GetFullDetails()
    {
        base.GetStandardDetails();
        Console.WriteLine($"Please RSVP at {_email}");
    }

    public void GetShortDetails()
    {
        Console.WriteLine("----Reception-----");
        Console.WriteLine(_title);
        Console.WriteLine($"Date: {_date}");
    }
}