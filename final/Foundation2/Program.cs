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
        Address address1 = new Address("Smiley Rd", "Pleasanton", "CA", "USA");
        order1.AddCustomer("Jorge Menjivar", address1);
        orders.Add(order1);

        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            order.GetPackingLabel();
            Console.WriteLine();
            Console.WriteLine("Shipping Label:"); 
            order.GetShippingLabel();
            Console.WriteLine();
            Console.Write("Order Total: "); 
            Console.WriteLine($"${order.CalculateTotalPrice()}");
                       
        }              

    }
}