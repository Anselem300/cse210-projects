using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Online Ordering Project.");
        Console.WriteLine();

        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Anselem Samuel", address1);

        Address address2 = new Address("14 Eagle Avenue", "Portharcourt","Rivers state", "Nigeria");
        Customer customer2 = new Customer("John McKean", address2);

        Order order1 = new Order(customer1);
        order1.AddProducts(new Product("Headphone", "CE234", 200, 2));
        order1.AddProducts(new Product("Laptop", "A1246", 800, 1));
        order1.AddProducts(new Product("Mouse", "VI234", 50.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProducts(new Product("Earring", "FT456", 86.9, 4));
        order2.AddProducts(new Product("T-Shirt", "GY345", 50.1, 5));
        order2.AddProducts(new Product("Tie", "WR432", 6.89, 2));

        Console.WriteLine("Order 1 Packing Label");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label");
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Price: ${order1.CalculateTotalPrice()}.");

        Console.WriteLine();
        Console.WriteLine("order 2 Packing Label");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label");
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Price: ${order2.CalculateTotalPrice()}");

    }
}