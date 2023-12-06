using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>
        {
            new Lectures("No one is better than you but you", "Learn how to overcome challenges through our guide for greatness", "December 15th, 2023", "5:00 PM", new Address("465 Smiley Rd", "Pleasanton", "CA", "USA"), "Justin Vela", 300),
            new Receptions("Exquisite Evenings", "Exquisite Evenings: Where elegance meets unforgettable moments.", "January 14th, 2023", "7:00 PM", new Address("4996 Cassells St", "North Bay", "ON", "CAN"), "exquisiteevenings@gmail.com"),
            new Outdoor("NatureVentures: Embrace the Wild", "Outdoor Excursions for Thrill Seekers", "April 10th, 2024", "5:00 AM", new Address("123 Main Street", "New York City", "NY", "USA"), "Partly Cloudly")
        };

        foreach (var evnt in events)
        {
            Console.WriteLine();
            Console.WriteLine($"---{evnt.GetType().Name.ToUpper()}---");
            Console.WriteLine();
            Console.WriteLine("-Standard Details-");
            Console.WriteLine(evnt.GetStandard());
            Console.WriteLine();
            Console.WriteLine("-Full Details-");

            if (evnt is Lectures lectures)
            {
                Console.WriteLine(lectures.GetFullDetails());
            }
            else if (evnt is Receptions receptions)
            {
                Console.WriteLine(receptions.GetFullDetails());
            }
            else if (evnt is Outdoor outdoor)
            {
                Console.WriteLine(outdoor.GetFullDetails());
            }
            Console.WriteLine();
            Console.WriteLine("-Short Details-");
            Console.WriteLine(evnt.GetShort());
        }
    }
}