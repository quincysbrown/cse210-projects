using System;
using System.ComponentModel.DataAnnotations;

public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override string GetActivityType()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
}