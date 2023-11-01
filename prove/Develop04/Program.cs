using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity task1 = new BreathingActivity();
        task1.GetStartingMessage();
        task1.RunBreathingActivity();
        Console.Write(task1.DisplayFinishingMessage());
    }
}