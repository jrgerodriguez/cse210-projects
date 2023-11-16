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

        return $"[{cross}] {_name} {_description} -- Currently Completed: {timesDone}/{_times}";
    }

    public override int RegisterGoal()
    {
        timesDone++;
        if (timesDone == _times)
        {
            IsCompleted();
            return base.RegisterGoal() + _bonus;
        }
        return base.RegisterGoal();
    }

    public override string ToSavedString()
    {
        return $"{this.GetType()},{_name},{_description},{_points},{_times},{_bonus},{timesDone}";
    }

}