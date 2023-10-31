using System;

public class Activity
{

    private string _name;
    private string _description;
    private int _duration;

public Activity(string name, string description)
{
    _name = name;
    _description = description;
}

public void GetStartingMessage()
{
    Console.WriteLine($"Welcome to {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How Long, in second, would you like for your session? ");
    string duration = Console.ReadLine();
    _duration = int.Parse(duration);
}

public string DisplayFinishingMessage()
{
    return $"You have completed another {_duration} of the {_name}";
}

}