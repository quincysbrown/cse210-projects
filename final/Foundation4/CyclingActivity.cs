using System;

public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override string GetActivityType()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return (GetSpeed() / 60) * base.GetLength();
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}