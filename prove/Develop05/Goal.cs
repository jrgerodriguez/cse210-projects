using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;


    public Goal(string name, string description, int points, bool isCompleted = false)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    public Goal(string name, string description, int points, int times, int bonus, int _timesDone = 0, bool isCompleted = false)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    public abstract string GetString();

    public virtual int RegisterGoal()
    {
        return _points;
    }
    public void IsCompleted()
    {
        _isCompleted = true;
    }

    public virtual string ToSavedString()
    {
        return $"{this.GetType().Name},{_name},{_description},{_points}";
    }

}