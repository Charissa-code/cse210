// Base class for all goal derived classes. 
public abstract class Goal
{
    // shared attributes, attributes are protected so derived classes can access the values directly like when using GetDetailsString() and GetStringRepresentation()
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _goalType;
    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
    }


    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete())
            return $"[X] {_name}- {_description} --{_points} points";
        else
            return $"[ ] {_name}- {_description} --{_points} points";
    }
    public abstract string GetStringRepresentation();

    public virtual int GetPoints()
    {
        return _points;
    }

    public abstract string GetShortDetails();    
}