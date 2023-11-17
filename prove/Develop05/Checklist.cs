using System;

public class Checklist : Goal
{
    protected int _times;
    protected int _bonus;
    protected int _timesDone = 0;


    public Checklist(string name, string description, int points, int times, int bonus, int timesDone = 0) : base(name, description, points, times, bonus, timesDone)
    {
        _times = times;
        _bonus = bonus;
        _timesDone = timesDone;
    }

    public override string GetString()
    {
        string cross = " ";
        if (_timesDone == _times)
        {
            cross = "X";
        }

        return $"[{cross}] {_name} {_description} -- Currently Completed: {_timesDone}/{_times}";
    }

    public override int RegisterGoal()
    {
        _timesDone++;
        if (_timesDone == _times)
        {
            IsCompleted();
            return base.RegisterGoal() + _bonus;
        }
        return base.RegisterGoal();
    }

    public override string ToSavedString()
    {
        return $"{this.GetType()},{_name},{_description},{_points},{_times},{_bonus},{_timesDone},{_isCompleted}";
    }

}