// This class returns the Simple Goal data and if the goal event is complete or not by using true or false.

public class SimpleGoal : Goal
{

    private bool _isComplete;


    public SimpleGoal(string name, string description, int points, bool isComplete) : base("Simple Goal", name, description, points)
    {
        _isComplete = isComplete; 
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetShortDetails()
        {
            if (IsComplete())
                return $"[X] {_name}";
            else
                return $"[ ] {_name}";
        }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}

