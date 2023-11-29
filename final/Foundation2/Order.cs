using System.Reflection.Emit;
using System.Text;

public class Order
{
    private List<Product> products = new List<Product>();
    private List<Customer> customers = new List<Customer>();

    public void AddProduct(string Name, int ProductId, int Price, int Quantity)
    {
        products.Add(new Product(Name, ProductId, Price, Quantity));
    }

    public void AddCustomer(string Name, Address Address)
    {
        customers.Add(new Customer(Name, Address));
    }

    public int CalculateTotalPrice()
    {

        int beforeShipping = 0;
        int shippingCost = 0;

        foreach (var product in products)
        {
            beforeShipping += product.GetPrice();
        }

        foreach (var customer in customers)
        {
            if (customer.LivesInUsa() == true)
            {
                shippingCost = 15;
            }

            else
            {
                shippingCost = 35;
            }
        }

        return beforeShipping + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var product in products)
        {
            sb.AppendLine($"{product.PackingLabelString()}");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var customer in customers)
        {
            sb.AppendLine($"{customer.ShippingLabelString()}");
        }
        return sb.ToString();
    }

}