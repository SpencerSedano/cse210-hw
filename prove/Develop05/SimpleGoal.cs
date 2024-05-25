public class SimpleGoal : Goal
{
    public bool IsCompleted { get; set; }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        IsCompleted = false;
    }

    public override void RecordEvent()
    {
        IsCompleted = true;
    }

    public override bool IsComplete()
    {
        return IsCompleted;
    }

    public override string GetStringRepresentation()
    {
        return IsCompleted ? "[X] " + _shortName : "[ ] " + _shortName;
    }

    public override string GetDataRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{IsCompleted}";
    }
}
