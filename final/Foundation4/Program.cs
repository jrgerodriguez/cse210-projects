using System;

class Program
{
    static private List<Activity> activities = new List<Activity>();
    static void Main(string[] args)
    {

        activities.Add(new Running("07 Dec 2023", 30, 4.8));
        activities.Add(new Cycling("07 Dec 2023", 30, 8.5));
        activities.Add(new Swimming("07 Dec 2023", 30, 100));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}