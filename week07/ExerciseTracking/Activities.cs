using System;

public abstract class Activities
{
    private string _date;
    private double _minutes;
    public Activities(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }


    public string GetDate()
    {
        return _date;
    }
  
    public double GetMinutes()
    {
        return _minutes;
    }

    public abstract string GetActivity();
    public abstract double GetDistance();
    public abstract double GetPace();
    public abstract double GetSpeedMph();
  


    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetActivity()} ({GetMinutes()} mins)- Distance {GetDistance():F2} miles,  Speed {GetSpeedMph():F2} mph,  Pace: {GetPace():F2} minutes per mile";
    }
}