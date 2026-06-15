using System.IO;
//GoalManager will keep track of the lists of goals and keep track of  player scores.
public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start() //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Eternal Quest");
        LoadGoals();

        int option = 0;
        while (option != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create A New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write($"Select a choice from the menu: ");
            string input = Console.ReadLine();
            option = int.Parse(input);

            if (option == 1)
                CreateGoal();
            else if (option == 2)
                ListGoalNames();
            else if (option == 3)
                RecordEvent();
            else if (option == 4)
                SaveGoals();
            else if (option == 5)
                ListGoalDetails();
        }
    }


    public int GetLevel()
    {
        return _score / 1000;
    }


    public void DisplayPlayerInfo()  // Displays the players current score.
    {
        Console.WriteLine();
        Console.WriteLine("********************************************************");
        Console.WriteLine($"Total Score: {_score}");
        Console.WriteLine($"LEVEL: {GetLevel()}");
        Console.WriteLine();
        Console.WriteLine("********************************************************");
        Console.WriteLine();
    }

    public void CreateGoal()  // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.WriteLine("Goal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select the number of goal type that you want to create. ");
        string goalType = Console.ReadLine();
        Console.Write("Name of Goal: ");
        string name = Console.ReadLine();
        Console.Write("Description of Goal: ");
        string description = Console.ReadLine();
        Console.Write("Goal Point Value: ");
        string pointsInput = Console.ReadLine();
        int pointsValue = int.Parse(pointsInput);
        if (goalType == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(name, description, pointsValue);
            _goals.Add(newGoal);
        }
        else if (goalType == "2")
        {
            EternalGoal newGoal = new EternalGoal(name, description, pointsValue);
            _goals.Add(newGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many bonus points will you assign when you reach your target?");
            string bonusInput = Console.ReadLine();
            int bonus = int.Parse(bonusInput);
            Console.Write("How many times do you want to do this to attain your goal? (target)");
            string targetInput = Console.ReadLine();
            int target = int.Parse(targetInput);
            ChecklistGoal newGoal = new ChecklistGoal(name, description, pointsValue, bonus, 0, target);
            _goals.Add(newGoal);
        }
    }


    public void ListGoalNames()  // Lists the names of each of the goals.
    {
        Console.WriteLine();
        Console.WriteLine("Your list of goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortDetails()}");
        }
    }

    public void ListGoalDetails()  // Lists the details of each goal (including the checkbox of whether it is complete).
    {
        //loops through all of the individual GetDetailsString lines and compiles and prints them a the list of GetDetailsString. That is what makes ListGoalDetails
        Console.WriteLine();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    


    public void RecordEvent()  // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        ListGoalNames();
        Console.Write($"Which goal did you accomplish? ");
        string recordInput = Console.ReadLine();
        int record = int.Parse(recordInput);
        int goalIndex = record - 1;
        _goals[goalIndex].RecordEvent();
        int pointsEarned = _goals[goalIndex].GetPoints();
        _score += pointsEarned;
        Console.WriteLine();
        Console.WriteLine($"You have earned {pointsEarned} points!");
        if (_goals[goalIndex].IsComplete())
        {
            Console.WriteLine("Checklist Goal Completed! BONUS points awarded!!");
        }
    }



    public void SaveGoals()  // Saves the list of goals to a file.
    {
        string goalsFile = "goalsFile.txt";
        using (StreamWriter outputFile = new StreamWriter(goalsFile))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Your goals have been saved.");
    }



    public void LoadGoals()  // Loads the list of goals from a file.

    {
        string goalsFile = "goalsFile.txt";
        if (!File.Exists(goalsFile))
            return;
        string[] lines = System.IO.File.ReadAllLines(goalsFile);
        _score = int.Parse(lines[0]);
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] part = line.Split(":");
            string goalTypes = part[0];
            string[] dataParts = part[1].Split(",");

            if (goalTypes == "SimpleGoal")
            {
                string name = dataParts[0];
                string description = dataParts[1];
                string point = dataParts[2];
                _goals.Add(new SimpleGoal(name, description, int.Parse(point)));
            }

            else if (goalTypes == "EternalGoal")
            {
                string name = dataParts[0];
                string description = dataParts[1];
                string point = dataParts[2];
                _goals.Add(new EternalGoal(name, description, int.Parse(point)));
            }

            else if (goalTypes == "ChecklistGoal")
            {
                string name = dataParts[0];
                string description = dataParts[1];
                string point = dataParts[2];
                string bonus = dataParts[3];
                string amountCompleted = dataParts[4];
                string target = dataParts[5];
                _goals.Add(new ChecklistGoal(name, description, int.Parse(point), int.Parse(bonus), int.Parse(amountCompleted), int.Parse(target)));
            }
        }
    }
}







    





