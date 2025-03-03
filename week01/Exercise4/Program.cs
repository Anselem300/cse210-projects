using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int userNumber = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber !=  0)
        {
            Console.Write("Enter a number ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else
            {
                break;
            }

        }

        // finding the sum of the numbers

       float sum = 0;
       
       foreach (int item in numbers)
       {
        sum += item;
       }

       Console.WriteLine($"The sum is: {sum}");

       //    Looking for the average

       float average = sum / numbers.Count;
       Console.WriteLine($"The average is: {average}");

       // Finding the maximum number

       int max = numbers[0];
       foreach (int number in numbers)
       {
         if (number > max)
         max = number;
       }

       Console.WriteLine($"The max number is: {max}");

       //    finding the smallest positve number

       int minPositiveNumber = 9999999;
       foreach (int number in numbers)
       {
        if (number > 0 && number < minPositiveNumber)
        minPositiveNumber = number;
       }

       Console.WriteLine($"The min positive number is: {minPositiveNumber}");

      //   Sorting the list

      numbers.Sort();
      Console.WriteLine("The sorted list is: ");
      foreach (int number in numbers)
      {
        Console.WriteLine(number);
      }
    }
} 