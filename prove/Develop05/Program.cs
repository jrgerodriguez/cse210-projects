using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> _goals = new List<Goal>();

        int pointsEarned = 0; 
        
        do
        {

        Console.WriteLine();    
        Console.WriteLine($"You have {pointsEarned} points.");
        Console.WriteLine();    
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3.");
        Console.WriteLine("  4.");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();


        if (input == "1")
        {
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("What type of goal will you create? ");
            string goalTypeInput = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string point = Console.ReadLine();
            int points = int.Parse(point);  
    
            if (goalTypeInput == "1")
            {
                _goals.Add(new Simple(name, description, points));
            }

            if (goalTypeInput == "2")
            {
                _goals.Add(new Eternal(name, description, points));
            }

            if (goalTypeInput == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string timesNumber = Console.ReadLine();
                int times = int.Parse(timesNumber);

                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusNumber = Console.ReadLine();
                int bonus = int.Parse(bonusNumber);  

                _goals.Add(new Checklist(name, description, points, times, bonus));
            }
            
        }


        else if (input == "2")
        {
            Console.WriteLine();
            
            foreach(Goal goal in _goals)
            {    
                Console.WriteLine(goal.GetString());
            }
        }


        else if (input == "5")
        {

            Console.Write("Which goal did you accomplish? ");
            string goalTypeInput = Console.ReadLine();

            foreach (Goal goal in _goals)
            {
                if (goalTypeInput == "1" && goal is Simple simple)
                {
                    Console.WriteLine();
                    Console.WriteLine(simple.RegisterGoal());
                    pointsEarned += simple.GetPoints();
                }

                if (goalTypeInput == "2" && goal is Eternal eternal)
                {
                    Console.WriteLine();
                    Console.WriteLine(eternal.RegisterGoal());
                    pointsEarned += eternal.GetPoints();
                }

                if (goalTypeInput == "3" && goal is Checklist checklist)
                {
                    Console.WriteLine();
                    Console.WriteLine(checklist.RegisterGoal());
                    pointsEarned += checklist.GetPoints();
                }
            }

            Console.WriteLine($"You now have {pointsEarned} points.");
        }

        
        else if (input == "6")
        {
          break;
        }
        
        } while(true);        

    }
}