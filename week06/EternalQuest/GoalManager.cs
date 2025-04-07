using System.IO;
using System.Runtime.InteropServices.Marshalling;
public class GoalManager {
    private List<Goals> _goals = new List<Goals>();
    private int _score = 0;

    public GoalManager() {

    }
    public void Start() {
       string userChoice = "";

       while (userChoice != "6") {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points");

        Console.WriteLine("\nMenu Options:");
        Console.WriteLine(" 1. Creat New Goals");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Seelect a choice from the menu: ");

        userChoice = Console.ReadLine();

        switch(userChoice) {
            case "1":
            CreateGoal();
            break;

            case "2":
            Console.WriteLine("\nYour Goals: ");
            ListGoalDetails();
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
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Thanks for working on your goals {name}!");
            break;

            default:
            Console.WriteLine("Invalid choice! Please select a number from 1-6.");
            break;
        }

       }
    }

    public void AddPoints(int points) {
        Console.WriteLine($"Congratulations! You've earned {points} points!");
        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames() {
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"{i+1}. {_goals[i].ShortName()}");
        };
    }

    public void ListGoalDetails() {
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailedString()}");
        }
    }

    public void CreateGoal() {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goals newGoal = null;

        switch (choice){
            case "1":
             newGoal = new SimpleGoal(name, description, points);
             break;

            case "2":
             newGoal = new EternalGoal(name, description, points);
             break;

            case "3":
             Console.Write("How many times does this goal need to be accomplished for a bonus? ");
             int target = int.Parse(Console.ReadLine());

             Console.Write($"What is the bonus point for accomplishing it {target} time(s)? ");
             int bonus = int.Parse(Console.ReadLine());
             newGoal = new CheckListGoal(name,description, points, target, bonus);
             break;
        }
        if (newGoal != null) _goals.Add(newGoal);
    }

    public void RecordEvent() {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) -1;

        if (index >= 0 && index < _goals.Count) {
            _goals[index].RecordEvent(this);
        }
    }

    public void SaveGoals() {
       Console.Write("What is the filename for the goal file? ");
       string filename = Console.ReadLine();

       using (StreamWriter output = new StreamWriter(filename)) {
        output.WriteLine(_score);
        foreach(Goals goal in _goals) {
            output.WriteLine(goal.GetStringRepresentation());
        }
       }
    }

    public void LoadGoals() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals.Clear();
        if (File.Exists(filename)) {
            string[] lines =  File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for(int i = 1; i < lines.Length; i++) {
                string[] parts = lines[i].Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(",");

                switch (type) {
                    case "SimpleGoal":
                 var simpleGoal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                 simpleGoal.SetIsComplete(bool.Parse(data[3]));  
                 _goals.Add(simpleGoal);
                 break;

                    case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;

                    case "CheckListGoal":
                    var items = new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                    items.GetType().GetField("_amountCompleted", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .SetValue(items, int.Parse(data[5]));

                    _goals.Add(items);
                    break;
                }
            }
        }
    }
}