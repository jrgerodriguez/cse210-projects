using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int number = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of number, type 0 when finished: "); //getting numberfrom user to add to the list 


        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        
        foreach (int no in numbers)
        {
            Console.WriteLine($"Enter a number: {no}"); //Display the list
        }

        var sum = numbers.Sum(); // get the sum 
        Console.WriteLine($"The sum is {sum}");
        double ave = numbers.Average(); // get the average
        Console.WriteLine($"The average is {ave}");
        var max = numbers.Max(); // get the maximum
        Console.WriteLine($"The maximum number is {max}");


        // get the smallest positive number
        int smallestPositive = 999999999; 
        foreach (int x in numbers)
        {
            if (x > 0 && x < smallestPositive)
            {
                smallestPositive = x;
                
            }
            
        }

        Console.WriteLine($"The Smallest Positive Number is {smallestPositive}");

        // sorting and displaying list
        Console.WriteLine("The Sorted List is: "); 
        numbers.Sort();
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }

    }
}