public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base("ListingActivity", "This activity will help you reflect on the good things in your life. List as many things as you can to the following prompt.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are the people you've helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine($"*{GetRandomPrompt()}*");
        ShowSpinner(3);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = GetListFromUser(endTime);
        _count = responses.Count;
        Console.WriteLine($"You entered {_count} items!");
        DisplayEndingMessage();
    }


    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count());
        return _prompts[index];
    }

    private List<string> GetListFromUser(DateTime endTime)
    {
        List<string> input = new List<string>
        {
        };
        while (DateTime.Now < endTime)
        {
            Console.Write("--");
            input.Add(Console.ReadLine());
        }
        return input;   
    }
}