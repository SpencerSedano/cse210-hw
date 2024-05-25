using System.Text.Json;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score;

    public void CreateGoal(string name, string description, int points, string type, int targetAmount = 0, int bonus = 0)
    {
        switch (type)
        {
            case "Simple":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "Eternal":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "Checklist":
                goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonus));
                break;
        }
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                if (!goal.IsComplete())
                {
                    score += goal.GetPoints();
                }
                break;
            }
        }
    }

    public void DisplayAllGoals()
{
    Console.WriteLine("Displaying all goals:");
    foreach (var goal in goals)
    {
        Console.WriteLine(goal.GetStringRepresentation());
    }
    Console.WriteLine("End of goals list.");
}

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.GetDataRepresentation());
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string type;
            while ((type = reader.ReadLine()) != null)
            {
                string data = reader.ReadLine();
                var goal = CreateGoalFromData(type, data);
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }
    }

    private Goal CreateGoalFromData(string type, string data)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var json = JsonSerializer.Deserialize<Dictionary<string, object>>(data, options);

        string name = (string)json["Name"];
        string description = (string)json["Description"];
        int points = (int)json["Points"];

        switch (type)
        {
            case nameof(SimpleGoal):
                bool isComplete = (bool)json["IsComplete"];
                return new SimpleGoal(name, description, points) { IsCompleted = isComplete };
            case nameof(EternalGoal):
                return new EternalGoal(name, description, points);
            case nameof(ChecklistGoal):
                int amountCompleted = (int)json["AmountCompleted"];
                int targetAmount = (int)json["TargetAmount"];
                int bonus = (int)json["Bonus"];
                return new ChecklistGoal(name, description, points, targetAmount, bonus) { AmountCompleted = amountCompleted };
            default:
                return null;
        }
    }
}
