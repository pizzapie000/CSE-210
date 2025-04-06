class Program
{
    static void Main(string[] args)
    {
        // Names and addresses for our first customer
        Address address1 = new Address("456 mulberry ln", "Funky Town", "WI", "USA");
        Customer customer1 = new Customer("Joe thompson", address1);

        Product product1 = new Product("Rubber Chicken", "RC123", 12.99m, 2);
        Product product2 = new Product("Glow-in-the-Dark Socks", "GDS456", 8.99m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: {order1.TotalCost()}");

        // customer number 2
        Address address2 = new Address("99 Rainbow road", "Rainbow City", "ON", "Canada");
        Customer customer2 = new Customer("Princess Bubblegum", address2);

        Product product3 = new Product("Edible rainbow powder", "EG789", 5.49m, 5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: {order2.TotalCost()}");
    }
}
