using System;

public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return Math.Round(base.GetLength() / GetDistance(), 2);
    }
}