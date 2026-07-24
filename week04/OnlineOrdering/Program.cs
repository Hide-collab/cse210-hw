using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)
        Address address1 = new Address(
            "13003 Hatcliffe",
            "Consortium",
            "Harare",
            "Zimbabwe");

        Customer customer1 = new Customer("Hide Vhunzawabaya", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 800, 1));
        order1.AddProduct(new Product("Mouse", "P102", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P103", 45, 1));

        // Order 2 (International Customer)
        Address address2 = new Address(
            "45 Samora Machel Ave",
            "Harare",
            "Harare",
            "Zimbabwe");

        Customer customer2 = new Customer("Hide Vhunzawabaya", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P201", 500, 1));
        order2.AddProduct(new Product("Headphones", "P202", 60, 2));

        // Display Order 1
        Console.WriteLine("==================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("==================================");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost()}");

        // Display Order 2
        Console.WriteLine("\n==================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("==================================");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost()}");
    }
}