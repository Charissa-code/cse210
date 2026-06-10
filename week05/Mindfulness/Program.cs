using System;

// I exceeded expectations by adding additional spinners and countdown to make the program more smoothly and make it less confusing. I have added some design to enhance the output for the user's benefit in the ListingActivity class. In the BreathingActivity, I added a holding command so that the user can breath in with countdown, hold with countdown and breath out with countdown. All of this was done while still using the programming in the Activity base class for the spinners and countdowns.
class Program
{
    static void Main(string[] args)
    {
        int menuSelection = 0;
        while (menuSelection != 4)
        {
            Console.WriteLine("********************************");
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
        if (menuSelection == 4)
        {
            Console.WriteLine("Now go take on the day!");
        }
    }
}