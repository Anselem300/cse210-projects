using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(){
    }

    public virtual void Run()
    {
        Console.WriteLine("Welcome");
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }

    public void DisplayEndingMessage() {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You Completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner();
    }

    public void ShowSpinner() {
        List<string> _animationString = new List<string>();
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");

        foreach (string anime in _animationString)
        {
            Console.Write(anime);
            Thread.Sleep(400);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds) {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}