public class Receptions : Event
{
    private string _email;

    public Receptions(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetFullDetails()
    {
        return $"{GetStandard()}\nEmail for reservations: {_email}";
    }

}