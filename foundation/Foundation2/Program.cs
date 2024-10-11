using System;

class Program
{
    public static void Main(string[] args)
    {
        // Creating products for the first order
        Product product1 = new Product("Laptop", 101, 1200.50f, 1);
        Product product2 = new Product("Mouse", 102, 25.99f, 2);

        // Creating customer and address for the first order
        Address address1 = new Address("123 Maple St", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Creating the first order
        List<Product> productsList1 = new List<Product> { product1, product2 };
        Order order1 = new Order(productsList1, customer1);

        // Displaying the details of the first order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Subtotal:");
        Console.WriteLine($"${order1.Subtotal():F2}");
        Console.WriteLine();

        // Creating products for the second order
        Product product3 = new Product("Smartphone", 201, 799.99f, 1);
        Product product4 = new Product("Charger", 202, 19.99f, 1);
        Product product5 = new Product("Headphones", 203, 59.99f, 1);

        // Creating customer and address for the second order
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating the second order
        List<Product> productsList2 = new List<Product> { product3, product4, product5 };
        Order order2 = new Order(productsList2, customer2);

        // Displaying the details of the second order
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("Subtotal:");
        Console.WriteLine($"${order2.Subtotal():F2}");
    }
}