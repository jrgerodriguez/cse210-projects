using System;

public class ReflectionActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    private string DisplayPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;       
    }

    private string DisplayQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;        
    }

    public void RunReflectionActivity()
    {
        GetStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {DisplayPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press ENTER to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {DisplayQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
             
            i++;

            if (i >= _duration)
            {
                break;
            }          
        }
        DisplayFinishingMessage();
    }

}