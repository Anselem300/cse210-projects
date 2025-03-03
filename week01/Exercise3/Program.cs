using System;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playAgain = "yes";
        while (playAgain == "yes")
        { 
            Random randomMagicNumber = new Random();
            int magicNumber = randomMagicNumber.Next(1, 101);
            Console.WriteLine($"What is the magic number? {magicNumber}");
            int number = 0;
            int count = 0;
            while (number != magicNumber)
            {
               Console.Write("What is your guess? ");
               string answer = Console.ReadLine();
               count ++;
               number = int.Parse(answer);
               if ( number < magicNumber)
               {
                 Console.WriteLine("Higher");
               }
               else if (number > magicNumber)
               {
                 Console.WriteLine("Lower");
               }
               else
               {
                 Console.WriteLine("You guessed it!");
                 Console.WriteLine($"You guessed {count} time(s).");
               }
            }
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
            if (playAgain == "no")
            {
            Console.WriteLine("Thanks for playing this game with us!");
             }
        }
    }
}