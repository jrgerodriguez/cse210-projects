using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome(); //void, this does not need to include parameters or variable
        string userName = PromptUserName(); // userName will be what the function PromptUserName() returns
        int userNumber = PromptUserNumber(); // userNumber will be what the function PromptUserNumber() returns

        int sqr = SquareNumber(userNumber); // variable sqr will use what SquareNumber() return but SquareNumber() needs 
                                            // a paramenter to operate, taking userNumber

        DisplayResult(userName, sqr);   // this function is void, does not need to be included as a variable, however 
                                        // it will need to parameters, userName and sqr


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        } 



    }
}