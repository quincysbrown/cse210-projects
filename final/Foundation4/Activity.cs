using System;
using System.Formats.Asn1;

public abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public int GetLength()
    {
        return _length;
    }

    public string GetDate()
    {
        return _date;
    }

    public abstract string GetActivityType();
    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public virtual double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"-- {GetDate()} {GetActivityType()} ({GetLength()})- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile");
    }
}