using System;

class Program
{
    static void Main(string[] args)
    {
        // I added an additional creativity in line 51 - 58 of the GoalManager class where the user is prompted 
        // for their name for more personalization before exit and a code that reminds them to type in a valid number.

        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine();

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}