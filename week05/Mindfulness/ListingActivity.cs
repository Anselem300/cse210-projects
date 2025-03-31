public class ListingActivity : Activity {
    private int _count;

    private List<string> _userResponse = new List<string>();
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? "
    };


    public ListingActivity(){
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run() 
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime _starTime = DateTime.Now;
        DateTime _futureTime = _starTime.AddSeconds(_duration);

        while (DateTime.Now < _futureTime)
        {
            Console.Write("> ");
            _userResponse.Add(Console.ReadLine());
            _count = _userResponse.Count;
        }

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
     Random _random = new Random();
     Console.WriteLine($"--- { _prompts[_random.Next(_prompts.Count)]} ---");
    }

}