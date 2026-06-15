//ChecklistGoal should track the number of times the goal has been completed, the target number of times the user is striving for, and the bonus for achieving that target.
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    private bool _bonusAwarded;

    public ChecklistGoal(string name, string description, int points, int bonus, int amountCompleted, int target) : base("Checklist Goal", name, description, points)
    {
        _amountCompleted = amountCompleted; //always starts at 0
        _target = target;
        _bonus = bonus;
        _bonusAwarded = false;
    }
    public override void RecordEvent()//increments _amountCompleted
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            if (IsComplete()) //just now reached target so bonus isn't rewarded each time after target is met...
            {
                _bonusAwarded = true;
            }
        }
    }

    public override bool IsComplete()//returns true when _amountCompleted >= _target
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetPoints()//override to handle bonus points
    {
        if (_bonusAwarded)
        {
            _bonusAwarded = false; //reset so only awards once
            return _points + _bonus;//awards bonus
        }
        else //or
            return _points; //just return points minus bonus
    }
    public override string GetDetailsString()//override to show progress
    {
        if (!IsComplete())
            return $"[ ] {_name}- {_description} --{_points} points  --{_bonus} bonus  target{_amountCompleted}/{_target}";
        else
            return $"[X] {_name}- {_description} --{_points} points  --{_bonus} bonus  target{_amountCompleted}/{_target}";
    }

    public override string GetShortDetails()
    {
        if (IsComplete())
            return $"[X] {_name}  {_amountCompleted}/{_target}";
        else
            return $"[ ] {_name}  {_amountCompleted}/{_target}";
    }


    public override string GetStringRepresentation()//includes all extra attributes- include all details of goal in a way that is easy to save to a file and then load later
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_amountCompleted},{_target}";
    }
    
}

