using System;

public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string GetString()
    {
        return $"1. [ ] {_name} {_description}";        
    }

    public override string RegisterGoal()
    {
        
    }
}