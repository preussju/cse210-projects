public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int min, double speed) : base(date, min)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _lengthInMin / GetPace();
        double round = Math.Round(distance, 2);
        return round;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_lengthInMin} min): Distance {GetDistance()} Km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km.";
    }
}