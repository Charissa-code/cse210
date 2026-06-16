using System.Diagnostics;

public class Running : Activities
{
    private double _distance;

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    //
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeedMph()
    {
        return _distance / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }
    }