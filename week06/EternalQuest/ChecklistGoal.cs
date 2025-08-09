
using System.Data;
using System.Runtime.InteropServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points,int amountCompleted, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        int score = 0;
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            score += _points;

            if (_amountCompleted == _target)
            {
                score += _bonus;
            }
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal~~{base._shortName}~~{base._description}~~{base._points}~~{_amountCompleted}~~{_target}~~{_bonus}";
    }


    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})--Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})--Currently completed {_amountCompleted}/{_target}";
        }
    }
}


