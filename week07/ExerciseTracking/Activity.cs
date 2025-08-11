
using System.Diagnostics;
using System.Dynamic;
using System.Security.Cryptography;

public abstract class Activity
{

    protected string _date;
    protected int _lengthInMin;


    public Activity(string date, int min)
    {
        _date = date;
        _lengthInMin = min;

    }

    public abstract double GetDistance();

    public abstract double GetSpeed();
  
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} activity ({_lengthInMin}min): Distance {GetDistance()} Km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km.";
    }
}