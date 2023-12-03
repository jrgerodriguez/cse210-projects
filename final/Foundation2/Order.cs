using System.Reflection.Emit;
using System.Text;

public class Order
{
    private List<Product> products = new List<Product>();

    private Customer Customer;

    public void AddProduct(string Name, int ProductId, int Price, int Quantity)
    {
        products.Add(new Product(Name, ProductId, Price, Quantity));
    }

    public void SetCustomer(Customer customer)
    {
        Customer = customer;
    }

    public int CalculateTotalPrice()
    {

        int beforeShipping = 0;

        foreach (var product in products)
        {
            beforeShipping += product.GetPrice();
        }

        if (Customer.LivesInUsa() == true)
        {
            beforeShipping += 15;
        }

        else
        {
            beforeShipping += 35;
        }

        return beforeShipping;
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
        return Customer.ShippingLabelString();
    }

}