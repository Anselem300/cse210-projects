using System.Runtime.CompilerServices;

public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(){
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage() {

    }

    public void ShowSpinner() {

    }

    public void ShowCountDown() {

    }
}