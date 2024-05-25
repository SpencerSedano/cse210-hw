public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete.
    }

    public override string GetStringRepresentation()
    {
        return "[ ] " + _shortName;
    }

    public override string GetDataRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}