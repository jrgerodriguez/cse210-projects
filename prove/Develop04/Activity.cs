using System;

public class Activity
{

    private string _name;
    private string _description;
    protected int _duration;

public Activity(string name, string description)
{
    _name = name;
    _description = description;
}

protected void GetStartingMessage()
{
    Console.Clear();
    Console.WriteLine($"Welcome to {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How Long, in second, would you like for your session? ");
    string duration = Console.ReadLine();
    _duration = int.Parse(duration);
    Console.Clear();
    Console.WriteLine("Get Ready...");
    ShowSpinner(5); 
}

protected void DisplayFinishingMessage()
{
    Console.WriteLine();
    Console.WriteLine("Well Done!!!");
    ShowSpinner(5);
    Console.WriteLine();
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    ShowSpinner(5);
    Console.Clear();  
}


protected void ShowSpinner(int seconds)
{
            List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");  

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }          
        }
}

protected void ShowCountDown(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

}

}

