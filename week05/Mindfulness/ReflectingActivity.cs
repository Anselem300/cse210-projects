public class ReflectingActivity : Activity {
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    public ReflectingActivity() {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power your have and how you can use it in other aspects of your life.";
    }

    private Random _random = new Random();

    public override void Run() {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompts:");
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter key to continue.");
        Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime _starTime = DateTime.Now;
        DateTime _futureTime = _starTime.AddSeconds(_duration);

        while (DateTime.Now < _futureTime)
         {
            DisplayQuestions();
            ShowSpinner();
            Console.WriteLine();
         }

         DisplayEndingMessage();
    }

    public string GetRandomPrompt()  
    {
        return $"--- {_prompts[_random.Next(_prompts.Count)]} ---";
    }

    public string GetRandomQuestion()
    {
        return $"{_questions[_random.Next(_questions.Count)]}";
    }

    public void DisplayPrompt() 
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}