class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        string filePath = "goals.dat";
        try
        {
            goalManager.LoadGoals(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No existing goals found. Starting fresh.");
        }


        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest Goal Tracker");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record a goal event");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayAllGoals();
                    break;
                case "3":
                    goalManager.SaveGoals(filePath);
                    break;
                case "4":
                    try
                    {
                        goalManager.LoadGoals(filePath);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("No existing goals found.");
                    }
                    break;
                case "5":
                    RecordGoalEvent(goalManager);
                    break;
                case "6":
                    goalManager.SaveGoals(filePath);
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing the goal: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points value. Please enter a valid integer.");
            return;
        }

        Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine();

        int targetAmount = 0;
        int bonus = 0;

        if (type == "Checklist")
        {
            Console.Write("Enter target amount: ");
            if (!int.TryParse(Console.ReadLine(), out targetAmount))
            {
                Console.WriteLine("Invalid target amount. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter bonus points for completing the goal: ");
            if (!int.TryParse(Console.ReadLine(), out bonus))
            {
                Console.WriteLine("Invalid bonus points. Please enter a valid integer.");
                return;
            }
        }

        goalManager.CreateGoal(name, description, points, type, targetAmount, bonus);
        Console.WriteLine("Goal created successfully!");
    }

    static void RecordGoalEvent(GoalManager goalManager)
    {
        Console.Write("Enter the name of the goal for which to record an event: ");
        string goalName = Console.ReadLine();

        goalManager.RecordEvent(goalName);
        Console.WriteLine("Event recorded successfully!");
    }
}