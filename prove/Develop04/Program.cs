using System;

class Program
{
    static void Main(string[] args)
    {
        int times = 0;

        do
        {        

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflection Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
        BreathingActivity act1 = new BreathingActivity();
        act1.RunBreathingActivity();        
        }

        else if (input == "2")
        {
        ReflectionActivity act2 = new ReflectionActivity();
        act2.RunReflectionActivity();              
        }

        else if (input == "3")
        {
        ListingActivity act3 = new ListingActivity();
        act3.RunListinActivity();  

        }

        else if (input == "4")
        {
            Console.WriteLine();
            Console.WriteLine("Come back soon!");
            Console.WriteLine();
            Console.WriteLine($"You performed {times} activities");
            break;
            
        }

        else 
        {
            Console.WriteLine();
            Console.WriteLine("Wrong entry, try again");
            Console.WriteLine();
        }

        times++;

        } while (true);

        

    }
}