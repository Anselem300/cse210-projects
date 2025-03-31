using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // I added an additional creativity in line 42-50 where the code takes the user back to the menu
        // When they type in a number that is not contained in the menu provided and a display message to quit in line 39.

        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice) 
            {
                case "1":
                  activity = new BreathingActivity();
                  break;
                case "2":
                  activity = new ReflectingActivity();
                  break;
                case "3":
                  activity = new ListingActivity();
                  break;
                case "4":
                  Console.WriteLine("Have a nice day!");
                  return;

                default:
                  Console.Write("Choice not found in menu! try again...");
                  for (int i = 0; i < 6; i++)
                  {
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write("\b");
                  }
                  continue;
            }

               if (activity != null)
               {
                activity.Run();
               }
        }
    }
}