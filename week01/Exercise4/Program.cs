using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Write a number. Enter '0' when you are finished.");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (userNumber != "0")
                numbers.Add(number);
        }

        Console.WriteLine($"The total of all numbers is {numbers.Sum()}.");
        Console.WriteLine($"The average of all numbers is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");

        int smallestPos = numbers.Where(n => n > 0).Min();  //.Where goes through every item in numbers and returns on the ones "where" the condition is true. (n => n > 0) is called a lambda expression. "Take each number n and check if n>0." if true-keep  if false- ignore it. Like a sieve that removes items you don't want.
        Console.WriteLine($"The smallest positive number is {smallestPos}.");
          

    }
}