using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks the user for their name

        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}