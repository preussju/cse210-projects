
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

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
        string choice = "";
        while (choice != "quit")
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                choice = "quit";
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Start();
            }
        }
    }

    public void DisplayPlayerInfo() //displays user's score
    {
        foreach (Goal goal in _goals)
        {
            string[] parts = goal.GetStringRepresentation().Split("~~");

            if (parts[1] == "EternalGoal")
            {
                int points = int.Parse(parts[3]);
                _score += points; // Add points from eternal goals
            }
            if (goal.IsComplete())
            {
                if (parts.Length >= 3)
                {
                    int points = int.Parse(parts[3]);
                    _score += points; // Add points from each goal to the score
                }
            }
        }
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine();
    }

    public void ListGoalNames() //Lists the names of each of the goals.
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] parts = _goals[i].GetStringRepresentation().Split("~~");
            if (parts.Length >= 3)
            {
                Console.WriteLine($"{i + 1}. {parts[1]}");
            }
        }
    }

    public void ListGoalDetails() //Lists the details of each goal (including the checkbox of whether it is complete).
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? (1-3): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("what's the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("What's the description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("What's the amount of points for the goal? ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
            Console.WriteLine("Simple Goal created successfully!");
        }
        else if (choice == "2")
        {
            Console.Write("What's the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("What's the description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("What's the amount of points for the goal? ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
            Console.WriteLine("Eternal Goal created successfully!");
            
        }
        else if (choice == "3")
        {
            Console.Write("What's the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("What's the description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("What's the amount of points for the goal? ");
            int points = int.Parse(Console.ReadLine());

            Console.Write("What's the target number of completions for the goal? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What's the bonus points for completing the goal? ");
            int bonus = int.Parse(Console.ReadLine());

            int amount = 0; // Initialize amountCompleted to 0

            Goal newGoal = new ChecklistGoal(name, description, points, amount, target, bonus);
            _goals.Add(newGoal);
            Console.WriteLine("Checklist Goal created successfully!");
        }

        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            CreateGoal();
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        ListGoalNames();
        Console.Write("Which goal (enter the number): ");
        int input = int.Parse(Console.ReadLine()) - 1;

        if (input < 0 || input >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }
        Goal selectedGoal = _goals[input];
        selectedGoal.RecordEvent();
    }

    public void SaveGoals() //saves the list of goals to a file
    {

        Console.WriteLine("What's the name of the file to save goals to? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score); // Save the score as the first line
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");

    }

    public void LoadGoals()
    {
        Console.WriteLine("What's the name of the file to load goals from? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("~~");
                if (parts.Length >= 4)
                {
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (goalType == "SimpleGoal")
                    {
                        _goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (goalType == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        int amount = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        _goals.Add(new ChecklistGoal(name, description, points, amount, target, bonus));
                    }

                }
                if (parts.Length <= 1)
                {
                    _score = int.Parse(parts[0]);
                }
            }
        }

    }

}