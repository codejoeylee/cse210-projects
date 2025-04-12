using System;
using System.Collections.Generic;

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
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            points = 0;
        }

        Console.WriteLine("Choose goal type (1 = Simple, 2 = Eternal, 3 = Checklist): ");
        if (!int.TryParse(Console.ReadLine(), out int type))
        {
            type = 1;
        }

        Goal? goal = null;

        if (type == 1)
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (type == 2)
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (type == 3)
        {
            Console.Write("Enter target: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                target = 1;
            }

            Console.WriteLine("Enter bonus: ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                bonus = 0;
            }

            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine("Goal created successfully!");
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Goal? goal = null;

                    if (parts[0] == "SimpleGoal" && parts.Length >= 5)
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (isComplete) goal.RecordEvent();
                    }
                    else if (parts[0] == "EternalGoal" && parts.Length >= 4)
                    {
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    }
                    else if (parts[0] == "ChecklistGoal" && parts.Length >= 7)
                    {
                        goal = new ChecklistGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            int.Parse(parts[4]),
                            int.Parse(parts[5]));
                    }

                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            _score += _goals[choice - 1].RecordEvent();
            Console.WriteLine($"Event recorded! Current score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}




