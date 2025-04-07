using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Blue", 5));
        shapes.Add(new Rectangle("Yellow", 5, 4));
        shapes.Add(new Circle("Black", 3.7));

        foreach (Shape items in shapes)
        {
            string color = items.GetColor();
            double area = items.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

        Console.WriteLine();
    }
}