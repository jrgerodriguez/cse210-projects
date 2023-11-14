using System;

public class Checklist : Goal
{

    private int _times;
    private int _bonus;
    private int timesDone = 0;
     
    public Checklist(string name, string description, int points, int times, int bonus) : base(name, description, points)
    {
        _times = times;
        _bonus = bonus;
    }

    public override string GetString()
    {
        string cross = " ";
        if (_isCompleted == true)
        {
            cross = "X";
        }
             
        return $"3. [{cross}] {_name} {_description} -- Currently Completed: {timesDone}/{_times}"; 
    }

    public override string RegisterGoal()
    {
        timesDone++;
        if (timesDone == _times)
        {
            IsCompleted();
            _points += _bonus;
        }
        return $"Congratulations you have earned {_points} points!";
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType()}:{_name},{_description},{_points},{_times},{_bonus}";
    }

}