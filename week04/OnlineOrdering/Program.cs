using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA Customer)
        Address addr1 = new Address("123 Maple Street", "Provo", "UT", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Mechanical Keyboard", "KB-101", 75.50, 1));
        order1.AddProduct(new Product("Wireless Mouse", "MS-202", 25.00, 2));

        // ORDER 2 (International Customer)
        Address addr2 = new Address("45 Aba Road", "Port Harcourt", "Rivers", "Nigeria");
        Customer cust2 = new Customer("Franklin Anyaogu", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Ultrawide Monitor", "MN-303", 300.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "CB-404", 15.00, 3));

        // DISPLAY RESULTS
        Console.WriteLine("==============================");
        Console.WriteLine("ORDER 1 DETAILS");
        Console.WriteLine("==============================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotal():0.00}\n");

        Console.WriteLine("==============================");
        Console.WriteLine("ORDER 2 DETAILS");
        Console.WriteLine("==============================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotal():0.00}\n");
    }
}