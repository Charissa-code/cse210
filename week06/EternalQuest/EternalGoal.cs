// This class displays the name, description and points that are represented the Eternal Goal category in the game. 
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base("Eternal Goal", name, description, points)
    {
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
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
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}

