using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

            
        do 
        {
        
        scripture.GetScripture();
        Console.WriteLine();
        Console.WriteLine("Press ENTER to hide some words or type 'quit' and press ENTER to stop playing.");
        string input = Console.ReadLine();
        if (input == "quit")
        {
            break;
        }
        
        if (scripture.TotallyHidden() == true)
        {
            break;
        }

        Console.Clear();

        scripture.HideWords();

    }   while (true);

    } 

        
    

      
    
}