using System;

public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {

    }
    
    public override string GetString()
    {
        string cross = " ";
        if (_isCompleted == true)
        {
            cross = "X";
        } 
        return $"1. [{cross}] {_name} {_description}"; 
    }

    public override string RegisterGoal()
    {
        IsCompleted();
        return $"Congratulations you have earned {_points} points!";
    }



}