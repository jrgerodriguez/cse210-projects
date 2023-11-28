public class Product
{
    private string Name;
    private int ProductId;
    private int Price;
    private int Quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public int GetPrice()
    {
        return Price * Quantity;
    }

    public string PackingLabelString()
    {
        return $"Name: {Name}, Product ID: {ProductId}.";
    }
}