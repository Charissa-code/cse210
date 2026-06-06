public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds do you want to do this activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Begin");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("This ends your mindfulness exercise.");
        Console.WriteLine("Great job!");
        ShowSpinner(5);
        Console.WriteLine($"You have just completed {_name} for {_duration} seconds.");
        ShowSpinner(5);
        Console.WriteLine("Now go take on the day.");
    }

    public void ShowSpinner(int seconds)
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> spinAnimations = new List<string>();
        spinAnimations.Add("|");
        spinAnimations.Add("/");
        spinAnimations.Add("-");
        spinAnimations.Add("\\");
        spinAnimations.Add("-");
        spinAnimations.Add("\\");
        spinAnimations.Add("|");

        while (DateTime.Now < endTime)
        {
            foreach (string s in spinAnimations)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b\b  \b\b");
            }
        }
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }


}