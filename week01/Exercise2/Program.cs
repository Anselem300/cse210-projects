using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();
        Console.Write("Please input your Grade Percentage: ");
        string GPA = Console.ReadLine();
        int gradePercentage = int.Parse(GPA);
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // Determining the Grade sign
        string sign = "";
        int lastDigit = gradePercentage % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        if (gradePercentage >= 93)
        {
            sign = "";
        }
        else if (gradePercentage < 60)
        {
            sign = "";
        }

        Console.WriteLine($"Your Grade Point Average is: {letter}{sign}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats! You passed.");
        }
        else
        {
            Console.WriteLine("You can do better.");
        }
    }
}