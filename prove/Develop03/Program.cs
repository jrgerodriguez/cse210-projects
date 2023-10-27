using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        //This is the verse (Reference + Scripture)
        Console.WriteLine();
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
 

        // Here we set the level of difficulty
        Console.WriteLine("Let's pick a difficulty, the more words are hidden, the more difficult it gets to memorize the scripture.");
        Console.WriteLine("How many words would you like to hide everytime you hit ENTER?");
        Console.WriteLine("(1 word = easy, 2 or 3 words = medium, 5+ words = hard)");
        Console.WriteLine();
        string difficulty = Console.ReadLine();
        Console.WriteLine();
        int difficultyNumber = int.Parse(difficulty);

        do 
        {

        //The scripture is displayed along with the instructions
        scripture.GetScripture();
        Console.WriteLine();
        Console.WriteLine("Press ENTER to hide some words or type 'quit' and press ENTER to stop playing.");
        string input = Console.ReadLine();

        Console.Clear();

        scripture.HideWords(difficultyNumber);

        if (input == "quit")
        {
            break;
        }
        
        if (scripture.TotallyHidden() == true)
        {
            break;
        }

    }   while (true);

    }     
}