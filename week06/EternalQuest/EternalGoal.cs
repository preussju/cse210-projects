
public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        int score = 0;
        score += _points; // Increment points when the goal is recorded
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }
    
    public override string GetStringRepresentation()
    {
        return $"EternalGoal~~{base._shortName}~~{base._description}~~{base._points}";
    }

}
