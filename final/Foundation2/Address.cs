public class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    private bool liveInUsa;

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        liveInUsa = false;
    }

    public void Location()
    {
        if (Country == "usa" || Country == "USA")
        {
            liveInUsa = true;
        }
    }

    public bool IsInUsa()
    {
        return liveInUsa;
    }

    public string GetAddressString()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}