using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? Number only. ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        int remainder = percent % 10;
        

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "A" && letter != "F")
        {
            if (remainder >= 7)
            {
                letter += "+";
            }
            else if (remainder <= 3)
            {
                letter += "-";
            }
        }
        
        Console.WriteLine($"Your grade is {letter} ");

        if (percent >= 60)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.Write("Sorry, you did not pass this time. Keep going and you'll get it next time.");
        }


    }
}