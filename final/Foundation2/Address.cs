public class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;


    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUsa()
    {
        if (Country == "usa" || Country == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string GetAddressString()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}