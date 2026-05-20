using System;
//I repeated back to the screen what option the user selected. I also created an exception code to handle if the wrong filename was typed.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the My Journal program!");
        Console.WriteLine("Please choose a numbered option:");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");        
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Finished");
            
        Journal myJournal = new Journal();
        PromptGenerator myPrompt = new PromptGenerator();
        string optionNumber = "";
        
        while (optionNumber != "5")
        {
            Console.WriteLine("What would you like to do?");
            optionNumber = Console.ReadLine();
            Console.WriteLine($"You chose option {optionNumber}.");


            if (optionNumber == "1")
            {
                myJournal.AddEntry(myPrompt.GetRandomPrompt());
            }
            
            //DISPLAY ALL ENTRIES
            if (optionNumber == "2")
                myJournal.DisplayAll();

            //SAVE JOURNAL ENTRY TO USER INPUT FILENAME
            if (optionNumber == "3")
            {
                Console.WriteLine("Create a filename to save your journal entries to.");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }

            //LOAD FILE FROM USER SAVED FILENAME. IF INCORRECT- USER REPROMPTED TO PREVENT CRASH
            if (optionNumber == "4")
            {
                string filename = "";
                while (!File.Exists(filename))
                {
                    Console.WriteLine("Enter the filename to load.");
                    filename = Console.ReadLine();
                    if (!File.Exists(filename))
                    {
                        Console.WriteLine("Filename not found. Please enter the correct filename.");
                    }
                }
                myJournal.LoadFromFile(filename);
                myJournal.DisplayAll();
            }

            //QUITE
            if (optionNumber == "5")
            {
                Console.WriteLine("Great Job Today!");
            }
        
        }
    }
}


