using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> _goals = new List<Goal>();

        do
        {

        Console.WriteLine();    
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3.");
        Console.WriteLine("  4.");
        Console.WriteLine("  5.");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();

        if (input == "1")
        {

            Console.Write("What type of goal will you create? ");
            string goalTypeInput = Console.ReadLine();
    
            if (goalTypeInput == "1")
            {
        
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string point = Console.ReadLine();
                int points = int.Parse(point);     
        
                _goals.Add(new Simple(name, description, points));
            }
        }

        else if (input == "2")
        {
            foreach(Goal goal in _goals)
            {
                Console.WriteLine();
                Console.WriteLine(goal.GetString());
            }
        }

        
        else if (input == "6")
        {
          break;
        }
        
        } while(true);        

    }
}