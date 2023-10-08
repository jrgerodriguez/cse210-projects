using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        Entry entry = new Entry();
        Journal journal = new Journal();

        while (true)
        {

        Console.WriteLine();
        Console.WriteLine("Welcome to your Journal \nPlease select one of the options:");
        Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        Console.WriteLine("What whould you like to do?");
        Console.WriteLine();

        string activityNumber = Console.ReadLine();


        if (activityNumber == "1")        
        {
    
    
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
            Random random = new Random();
            int randomChoice = random.Next(0, prompts.Count);
            string randomPrompt = prompts[randomChoice];
            Console.WriteLine(randomPrompt);
            string response = Console.ReadLine();
            Console.WriteLine("What scripture did your read today?");
            string scriptureRead = Console.ReadLine();
            entry = new Entry();
                        
            
            entry._prompt = randomPrompt;
            entry._date = DateTime.Now.ToString();
            entry._answer = response;
            entry._scripture = scriptureRead;
            journal.AddEntry(entry);
            
        }


        else if (activityNumber == "2")        
        {
            journal.DisplayEntries();                                
        }


        else if (activityNumber == "3")
        {
            Console.Write("Enter the name of the file that you want to load: ");
            string fileName = Console.ReadLine();
            journal.LoadFile(fileName);
        }        


        else if (activityNumber == "4")
        {
            Console.Write("Enter the name of the file that you want to save your entries to: ");
            string fileName = Console.ReadLine();
            journal.SaveToFile(fileName);
        }


        else if (activityNumber == "5")
        {
            Console.WriteLine("Have a good day.");
            break;
        }

        }
               
    
    }
    
}