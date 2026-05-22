using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("                                  WELCOME TO SCRIPTURE MEM");
        Console.WriteLine("Try to memorize this scripture. Press ENTER to hide the words displayed in the scripture until they are all hidden. Good Luck. Press ENTER to start.");
        Console.ReadLine();
        Console.Clear();
        Reference reference = new Reference("Mathew", 19, 26, 30);
        Scripture scripture = new Scripture(reference, "But Jesus beheld them and said unto them with men this is impossible but with God all things are possible.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Enter to hide words | QUIT to end");
            string input = Console.ReadLine();

            if (input.ToUpper() == "QUIT")
            {
                Console.WriteLine("Great Job!");
                Console.ReadLine();
                break;
            }

            else
            {
                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine(scripture.GetOriginalText());
        Console.WriteLine("Great Job!");
    }
}