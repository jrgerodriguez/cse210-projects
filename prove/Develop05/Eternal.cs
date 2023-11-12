using System;

public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string GetString()
    {
        return $"2. [ ] {_name} {_description}";        
    }
    public override string RegisterGoal()
    {
        return $"Congratulations you have earned {_points} points!";
    }


}