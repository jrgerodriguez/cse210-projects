using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order();
        order1.AddProduct("iPhone 13", 1234, 650, 1);
        order1.AddProduct("iPhone Case", 4321, 15, 1);
        order1.AddProduct("iPhone Charger", 3412, 50, 2);
        Address address1 = new Address("465 Smiley Rd", "Pleasanton", "CA", "USA");
        Customer customer1 = new Customer("Jorge Menjivar", address1);
        order1.SetCustomer(customer1);
        orders.Add(order1);

        Order order2 = new Order();
        order2.AddProduct("T-Shirts", 9876, 8, 20);
        order2.AddProduct("Trousers", 6789, 15, 25);
        order2.AddProduct("Socks (Pairs)", 7698, 5, 3);
        Address address2 = new Address("4996 Cassells St", "North Bay", "ON", "CAN");
        Customer customer2 = new Customer("Harvey Bradley", address2);
        order2.SetCustomer(customer2);
        orders.Add(order2);

        foreach (var order in orders)
        {
            Console.WriteLine("NEW ORDER:");
            Console.WriteLine();
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.Write("Order Total: ");
            Console.WriteLine($"${order.CalculateTotalPrice()}");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}