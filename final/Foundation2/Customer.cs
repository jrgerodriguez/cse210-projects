public class Customer
{
    private string Name;
    private Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool LivesInUsa()
    {
        return Address.IsInUsa();
    }

    public string ShippingLabelString()
    {
        return $"Name: {Name}, Address: {Address.GetAddressString()}.";
    }
}