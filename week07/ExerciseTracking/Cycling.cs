public class Cycling : Activities
{
    private double _speed;

    public Cycling(string date, double speed, double minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * GetMinutes();
    }
  
    public override double GetSpeedMph()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetActivity()
    {
        return "Cycling";
    }
}