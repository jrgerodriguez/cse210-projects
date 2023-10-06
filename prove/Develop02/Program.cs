using System;

class Program
{
    static void Main(string[] args)
    {
                    
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString();
        entry._prompt = "What was you favorite part of the day?";
        Console.WriteLine(entry._prompt);
        entry._answer = Console.ReadLine();

        Journal journal = new Journal();
        journal._entries.Add(entry);        
        journal.Display();
               
    }
}