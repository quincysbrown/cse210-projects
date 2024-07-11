using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetAmount()
    {
        return _amountCompleted;
    }
    public void SetAmount(int completed)
    {
        _amountCompleted = completed;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (IsComplete())
        {
            return base.GetPoints() + _bonus;
        }
        else
        {
            return base.GetPoints();
        }


    }

    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal~|~{base.GetName()}~|~{base.GetDescription()}~|~{base.GetPoints()}~|~{GetTarget()}~|~{GetBonus()}~|~{GetAmount()}";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Currently completed: {_amountCompleted}/{_target}";
    }
}