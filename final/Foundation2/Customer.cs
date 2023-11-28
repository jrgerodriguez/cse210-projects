public class Customer
{
    private string Name;
    private Address Address;

    private bool locatedinUsa;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public void LocatedInUsa()
    {
        locatedinUsa = Address.IsInUsa();
    }

    public bool LivesInUsa()
    {
        return locatedinUsa;
    }

    public string ShippingLabelString()
    {
        return $"Name: {Name}, Address: {Address.GetAddressString()}.";
    }
}