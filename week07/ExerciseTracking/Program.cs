using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activities> activities = new List<Activities>();
        activities.Add(new Running("03 Nov 2022", 20, 1));
        activities.Add(new Cycling("03 Nov 2022", 28, 30));
        activities.Add(new Swimming("03 Nov 2022", 25, 30));
            
        foreach (Activities activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}