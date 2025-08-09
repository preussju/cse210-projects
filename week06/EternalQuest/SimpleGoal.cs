
public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            int score = 0;
            score += _points; // Increment the score by the points of the goal
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal~~{base._shortName}~~{base._description}~~{base._points}~~{_isComplete}";
    }

}
