using System;

public class Resume {

    public string _name;
    public List<Job> _jobs = new List<Job>();  // List<Job> will will be de data type

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobs){
            job.Display(); // Here I am calling the Display method I set up for Jobs.cs
        }     
    }


    
}

//Complete
