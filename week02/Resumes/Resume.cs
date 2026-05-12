using System;
using System.Collections.Generic;

public class Resume

{
    public string _name = "";
       public List<Job> _jobs = new List<Job>(); // "Create a variable names _jobs that can hold many Job objects that myResume will later use."
      
    public void Display()
    {
        Console.WriteLine($"Name:{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs) //this line means "Go through each Job object inside the _jobs list created above."  _jobs = variable name
        {
            job.Display(); //This line calls the Display() method from Job class. (That's object-oriented programming working together.)
        }
    }
    
  
}