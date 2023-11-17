using System;

class Program
{
    static private List<Goal> _goals = new List<Goal>();
    static void Main(string[] args)
    {



        int pointsEarned = 0;

        do
        {

            Console.WriteLine();
            Console.WriteLine($"You have {pointsEarned} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("  7. Extra Points");
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
                DisplayGoals();
            }


            else if (input == "3")
            {
                Console.Write("What is the file name for the goal file? ");
                string filename = Console.ReadLine();

                using StreamWriter outputFile = new StreamWriter(filename);
                outputFile.WriteLine(pointsEarned);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.ToSavedString());
                }
            }


            else if (input == "4")
            {
                Console.Write("What is the file name for the goal file? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);
                pointsEarned = int.Parse(lines[0]);
                _goals.Clear();
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == "Simple")
                    {
                        _goals.Add(new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    }

                    else if (parts[0] == "Eternal")
                    {
                        _goals.Add(new Eternal(parts[1], parts[2], int.Parse(parts[3])));
                    }

                    else if (parts[0] == "Checklist")
                    {
                        _goals.Add(new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    }

                }
            }


            else if (input == "5")
            {
                DisplayGoals();

                Console.Write("Which goal did you accomplish? ");
                int goalIndex = int.Parse(Console.ReadLine());
                int points = _goals[goalIndex - 1].RegisterGoal();
                pointsEarned += points;

                Console.WriteLine();

                Console.WriteLine($"Congratulations you have earned {points} points!");

                Console.WriteLine($"You now have {pointsEarned} points.");
            }


            else if (input == "6")
            {
                break;
            }


            else if (input == "7")
            {
                Console.WriteLine();
                Console.WriteLine("Register any act of service to others and you automatically multiply your current points by 2");
                Console.WriteLine("You must register it on the same day it happened");
                Console.Write("Did you serve others today (yes/no)? ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! Serving others will help you live true discipleship, here are your extra points");
                    Console.WriteLine("Never forget: Verily I say unto you, Inasmuch as ye have adone it unto one of the bleast of these my cbrethren, ye have done it unto me.");
                    Console.WriteLine();
                    Console.WriteLine($"You have received {pointsEarned} extra points.");
                    pointsEarned *= 2;
                }

                else 
                {
                    Console.WriteLine("Pray for opportunities to serve others, you will surely find some.");
                }
            }

        } while (true);

    }
    static void DisplayGoals()
    {
        Console.WriteLine();

        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetString()}");
        }

        Console.WriteLine();
    }
}

