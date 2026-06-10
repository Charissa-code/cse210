public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectingActivity() :base("Reflecting Activity", "This activity will help you reflect on your strength and resilience through out your life. It will help you recognize the power that you do have and how you can use it in your life.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started with this experience?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DisplayPrompt();
        ShowSpinner(15);
        
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(15);    
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count());
        return _prompts[index];
    }

    private string GetRandomQuestions()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count());
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    
    private void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestions());
    }

}


