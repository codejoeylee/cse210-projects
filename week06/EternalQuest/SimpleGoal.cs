public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isCompleted = false;
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isCompleted}";
    }
}