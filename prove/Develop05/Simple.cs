using System;

public class Simple : Goal
{
    public Simple(string name, string description, int points, bool isCompleted = false) : base(name, description, points, isCompleted)
    {

    }

    public override string GetString()
    {
        string cross = " ";
        if (_isCompleted == true)
        {
            cross = "X";
        }
        return $"[{cross}] {_name} {_description}";
    }

    public override int RegisterGoal()
    {
        IsCompleted();
        return base.RegisterGoal();
    }

    public override string ToSavedString()
    {
        return $"{this.GetType().Name},{_name},{_description},{_points},{_isCompleted}";
    }
}