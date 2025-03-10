using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // I Added an additional creativity in line 14-17 and displayed in line 19 alongside other code, where 
        // the user is being prompted for their full name for a personalized experience.

        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.Write("Please what is your first name? ");
        string fName = Console.ReadLine();
        Console.Write("Please what is your last name? ");
        string lName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the Journal Program {fName} {lName}!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        

        while (true)
        {
            Console.WriteLine($"\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            switch (choice)
            {
               case "1":
                   string prompt = promptGenerator.GetRandomPrompt();
                   Console.Write(prompt);
                   string response = Console.ReadLine();
                   journal.AddEntry(prompt, response); 
                   break;
               case "2":
                   journal.DisplayAll();
                   break;
               case "3":
                   Console.Write("Enter filename to save the journal: ");
                   string saveFile = Console.ReadLine();
                   journal.SaveToFile(saveFile);
                   break;
               case "4":
                   Console.Write("Enter filename to load the journal: ");
                   string loadfile = Console.ReadLine();
                   journal.LoadFromFile(loadfile);
                   break;
               case "5":
                 return;
               default:
                  Console.WriteLine("Invalid option, please try again.");
                  break; 
            }             
        }
       
    }
}