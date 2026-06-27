public class BreathingActivity : Activity
{
    
    public BreathingActivity() : base("BreathingActivity", "Let's practice deep breathing.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(5);
            Console.WriteLine("Hold");
            ShowCountDown(5);
            Console.WriteLine("Breath out...");
            ShowCountDown(5);
            Console.WriteLine("Hold");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}
