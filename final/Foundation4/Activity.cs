public abstract class Activity
{
    private string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_length} min)- Distance: {GetDistance():N2} km, Speed: {GetSpeed():N2} kph, Pace: {GetPace():N2} min per km.";
    }
}