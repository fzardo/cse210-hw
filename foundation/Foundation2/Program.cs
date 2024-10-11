using System;

class Program
{
    public static void Main(string[] args)
    {
        // First order
        Order firstOrder = new Order(
            new List<Product>
            {
                new Product("Laptop", 101, 1200.50f, 1),
                new Product("Mouse", 102, 25.99f, 2)
            },
            new Customer("John Doe", new Address("123 Maple St", "Seattle", "WA", "USA"))
        );

        DisplayOrderDetails(firstOrder);

        // Second order
        Order secondOrder = new Order(
            new List<Product>
            {
                new Product("Smartphone", 201, 799.99f, 1),
                new Product("Charger", 202, 19.99f, 1),
                new Product("Headphones", 203, 59.99f, 1)
            },
            new Customer("Jane Smith", new Address("456 Oak St", "Toronto", "ON", "Canada"))
        );

        DisplayOrderDetails(secondOrder);
    }

    // Method to display order details (packing label, shipping label, and subtotal)
    private static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.ShippingLabel());

        Console.WriteLine("Subtotal:");
        Console.WriteLine($"${order.Subtotal():F2}");
        Console.WriteLine();
        Console.WriteLine("------------------------");
    }
}