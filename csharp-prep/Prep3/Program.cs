using System;

class Program
{
    static void Main(string[] args)
    {

        string playAgain = "yes";
        
        while (playAgain == "yes")
        {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

          
        
            int guessTimes = 0;
            int yourGuess = -1;
    
            while (yourGuess != magicNumber)
            {
    
                Console.Write("Guess the number: ");
                yourGuess = int.Parse(Console.ReadLine());
                guessTimes = guessTimes + 1;
    
                if (yourGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
        
                else if (yourGuess < magicNumber)
                {
                    Console.WriteLine("Greater");
                }
        
                else
                {
                    Console.WriteLine("Congratulations! You guessed it.");
                }
    
            }
    
            Console.WriteLine($"You took {guessTimes} times to guess the number");
            Console.WriteLine("Would you like to play again (yes/no)?");
            playAgain = Console.ReadLine();
        }


    }
}