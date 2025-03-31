using System.ComponentModel;

public class BreathingActivity : Activity {
    public BreathingActivity() {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."; 
    }

    public override void Run(){
        DisplayStartingMessage();

        DateTime _starTime = DateTime.Now;
        DateTime _futureTime = _starTime.AddSeconds(_duration);

        while (DateTime.Now < _futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(6);

            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }
}