using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // I added a few lines of code in line 11 - 18, which prompts the user for their full name 
        // and an action to continue which promotes a personalized interaction.

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Console.Write("What is your first name? ");
        string fName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lName = Console.ReadLine();

        Console.Write($"\nWelcome to the scripture memorizer program {fName} {lName}! Press Enter to continue. ");
        Console.ReadLine();

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress Enter to hide more words or type 'quit' to exit: ");

            string userInput = Console.ReadLine();
            if (userInput?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}