using System;


// Class: Job

// Attributes:
// *_jobTitle : string
// *_company : string
// *_startYear : int
// *_endYear : int

// Behaviors:
// void  Display the job info in the format "Job Title, Company, Start Year - End Year", 
public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void Display()

    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} - {_endYear}");
    }
}