public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice;

        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create new Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Archive Completed Goals");
            Console.WriteLine(" 7. Quit");
            Console.Write("Select a choice from the menu. ");

            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choice == 1) CreateGoal();
            else if (choice == 2) ListGoalNames();
            else if (choice == 3) SaveGoals();
            else if (choice == 4) LoadGoals();
            else if (choice == 5) RecordEvent();
            else if (choice == 6) ArchiveCompleted();
            else if (choice == 7) Environment.Exit(0);
            else Console.WriteLine("Invalid input, please try again.");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your Goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        string name;
        string description;
        int points;

        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");

        int choice;
        choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your Goal? ");
        name = Console.ReadLine();

        Console.Write("What is a short description of your Goal? ");
        description = Console.ReadLine();

        Console.Write("How many points associated with this Goal? ");
        points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (choice == 3)
        {
            Console.Write("Enter target completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input, please try again.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                Goal goal;

                if (parts[0] == "SimpleGoal")
                {
                    goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (parts[4] == "True")
                    {
                        ((SimpleGoal)goal).Completed();
                    }
                }
                else if (parts[0] == "EternalGoal") goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                else if (parts[0] == "ChecklistGoal")
                {
                    goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                    if (parts[4] != "0")
                    {
                        ((ChecklistGoal)goal).SetAmountCompleted(parts[4]);
                    }
                }
                else goal = null;

                if (goal != null) _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded.");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        
        Console.Write("Which goal did you accomplish? (Enter the number): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();
            Console.WriteLine($"You earned {_goals[index].GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void ArchiveCompleted()
    {
        using (StreamWriter writer = new StreamWriter("archived.txt", true))
        {
            // Create a temporary list to hold completed goals
            List<Goal> completedGoals = new List<Goal>();

            foreach (var goal in _goals)
            {
                if (goal.IsComplete())
                {
                    // Write the goal to the archived file
                    writer.WriteLine(goal.GetStringRepresentation());
                    completedGoals.Add(goal);
                }
            }

            // Remove completed goals from the main goals list
            foreach (var completedGoal in completedGoals)
            {
                _goals.Remove(completedGoal);
            }
        }

        Console.WriteLine("Completed goals archived.");
    }
}