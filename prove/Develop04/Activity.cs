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
    return $"You have completed another {_duration} seconds of the {_name}";
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

