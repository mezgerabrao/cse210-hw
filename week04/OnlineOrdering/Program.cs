using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer and order: customer lives in the USA.
        Address address1 = new Address(
            "125 Main Street",
            "Orlando",
            "Florida",
            "USA"
        );

        Customer customer1 = new Customer("Michael Johnson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Wireless Keyboard", "WK-1001", 29.99, 1)
        );

        order1.AddProduct(
            new Product("USB-C Cable", "UC-2045", 8.50, 2)
        );

        order1.AddProduct(
            new Product("Laptop Stand", "LS-3050", 35.00, 1)
        );

        // Second customer and order: customer lives outside the USA.
        Address address2 = new Address(
            "Avenida Sete de Setembro, 1500",
            "Salvador",
            "Bahia",
            "Brazil"
        );

        Customer customer2 = new Customer("Ana Oliveira", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Wireless Mouse", "WM-4010", 24.99, 2)
        );

        order2.AddProduct(
            new Product("Webcam", "WC-5025", 49.90, 1)
        );

        DisplayOrder("ORDER 1", order1);
        DisplayOrder("ORDER 2", order2);
    }

    static void DisplayOrder(string orderTitle, Order order)
    {
        Console.WriteLine($"========== {orderTitle} ==========");
        Console.WriteLine();

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine(
            $"TOTAL PRICE: ${order.CalculateTotalCost():F2}"
        );

        Console.WriteLine();
    }
}