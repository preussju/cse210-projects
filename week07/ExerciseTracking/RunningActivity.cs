public class RunningActivity : Activity
{
    private double _distance;


    public RunningActivity(string date, int min, double distance) : base(date, min)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = _distance / _lengthInMin * 60;
        double round = Math.Round(speed, 2);
        return round;
    }

    public override double GetPace()
    {
        double pace = _lengthInMin / _distance;
        double round = Math.Round(pace, 2);
        return round;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_lengthInMin} min): Distance {GetDistance()} Km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km.";
    }
}



