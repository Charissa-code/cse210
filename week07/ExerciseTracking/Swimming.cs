public class Swimming : Activities
{
    private int _laps;


    public Swimming(string date, int laps, double minutes) : base(date, minutes)
    {
        _laps = laps;
    }
    
    
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeedMph()
    {
        return GetDistance() / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetActivity()
    {
        return "Swimming";
    }


}