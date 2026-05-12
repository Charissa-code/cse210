using System;
using System.IO.Pipes;



class Program
{
    // Resume
    // _name : string
    // _job : List<Job>
    // void   Display the resume, which shows the name first, followed by displaying each one of the jobs.
    static void Main(string[] args)
    {
        Job job1 = new Job();  //Creating a object/instance from the Job class and then we store them inside a List<Job>.
        {
            job1._jobTitle = "Software Engineer";
            job1._company = "(Microsoft)";
            job1._startYear = "2019";
            job1._endYear = "2022";
        }

        Job job2 = new Job();
        {
            job2._jobTitle = "Manager";
            job2._company = "(Apple)";
            job2._startYear = "2022";
            job2._endYear = "2023";
        }

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1); //Means: myResume- Resume object,  ._jobs- access its list,  .Add(job1)- put job1 into the list
        myResume._jobs.Add(job2); //Means: myResume- Resume object,  ._jobs- access its list,  .Add(job2)- put job2 into the list

        myResume.Display();

        
    }
}