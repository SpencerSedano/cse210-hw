public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; set; }
    private int _targetAmount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus) : base(name, description, points)
    {
        AmountCompleted = 0;
        _targetAmount = targetAmount;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        AmountCompleted++;
        if (AmountCompleted == _targetAmount)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return AmountCompleted >= _targetAmount;
    }

    public override string GetStringRepresentation()
    {
        return $"Completed {AmountCompleted}/{_targetAmount} times - " + _shortName;
    }

    public override string GetDataRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{AmountCompleted}|{_targetAmount}|{_bonus}";
    }
}