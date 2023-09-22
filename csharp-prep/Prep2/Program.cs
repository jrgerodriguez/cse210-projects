using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Please enter your grade percentage: ");
        string gradePerStr = Console.ReadLine();
        int gPer = int.Parse(gradePerStr);

        string letter = "";

         if (gPer > 90)
        {
            letter = "A";
        }
         else if (gPer > 80)
        {
            letter = "B";
        }
         else if (gPer > 70)
        {
            letter = "C";
        }
         else if (gPer > 60)
        {
            letter = "D";
        }
         else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (gPer > 70)
        {
            Console.WriteLine("Congratulations! You pass.");
        }
        else 
        {
            Console.WriteLine("You did not pass.");
        }
    }
}