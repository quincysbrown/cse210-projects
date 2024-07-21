using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Customer customer1 = new Customer();
        customer1.SetName("John Doe");
        Address c1Address = new Address("2139 W 1570 N", "Ogden", "Utah", "USA");
        customer1.SetAddress(c1Address);
        Order order1 = new Order(customer1);
        Product c1Product1 = new Product("Ironing Board", 560004, 15.99, 1);
        order1.SetProduct(c1Product1);
        Product c1Product2 = new Product("White Dress Shirt", 470002, 28.75, 5);
        order1.SetProduct(c1Product2);
        Product c1Product3 = new Product("Dress Socks Assorted 10 Pair", 450006, 9.99, 2);
        order1.SetProduct(c1Product3);
        orders.Add(order1);

        Customer customer2 = new Customer();
        customer2.SetName("Jane Doe");
        Address c2Address = new Address("20 Heritage Rd.", "Boiestown", "New Brunswick", "Canada");
        customer2.SetAddress(c2Address);
        Order order2 = new Order(customer2);
        Product c2Product1 = new Product("Kitchen Stand Mixer Silver", 880054, 319.99, 1);
        order2.SetProduct(c2Product1);
        Product c2Product2 = new Product("Kitchen Knife Set", 880663, 199.99, 1);
        order2.SetProduct(c2Product2);
        Product c2Product3 = new Product("Women's Winter Hat", 450768, 16.75, 2);
        order2.SetProduct(c2Product3);
        orders.Add(order2);

        Console.Clear();
        foreach (Order order in orders)
        {
            Console.WriteLine("Order:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total Price: {order.GetTotalPrice()}");
            Console.WriteLine();
        }
    }
}