using System;


class Program
{
    static void Main(string[] args)
    {
        int menuSelection = 0;
        while (menuSelection != 4)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("   1.  Start Breathing Activity");
            Console.WriteLine("   2.  Start Reflecting Activity");
            Console.WriteLine("   3.  Start Listing Activity");
            Console.WriteLine("   4.  Quit");
            Console.WriteLine("Select a choice from the menu:");
            menuSelection = int.Parse(Console.ReadLine());

            if (menuSelection == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }


            if (menuSelection == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            if (menuSelection == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }
    }
}