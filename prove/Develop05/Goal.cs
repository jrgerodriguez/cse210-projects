using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract string GetString();

    public abstract string RegisterGoal();

    public int GetPoints()
    {
        return _points;
    }

    public void IsCompleted()
    {
        _isCompleted = true;
    }

    public abstract string GetStringRepresentation();

}