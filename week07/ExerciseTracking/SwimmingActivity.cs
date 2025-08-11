
using System.Reflection;

public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, int min, double laps) : base(date, min)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / _lengthInMin * 60;
        return speed;

    }

    public override double GetPace()
    {
        double pace = _lengthInMin / GetDistance();
        return pace;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_lengthInMin} min) -{_laps} laps: Distance {GetDistance()} Km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km.";
    }
}