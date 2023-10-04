using System;

public class Entry
{
    public string _prompt;
    public string _date;  
    public string _answer;

    public void Display() {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_answer);
    }

}