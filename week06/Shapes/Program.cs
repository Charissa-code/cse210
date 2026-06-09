using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(10.9, "white");
        Console.WriteLine($"The area of the square is {square.GetArea()} and the color is {square.GetColor()}.");

        Rectangle rectangle = new Rectangle(4, 5, "red");
        Console.WriteLine($"The area of the rectangle is {rectangle.GetArea()} and the color is {rectangle.GetColor()}.");

        Circle circle = new Circle(10, "blue");
        Console.WriteLine($"The area of the circle is {circle.GetArea()} and the color is {circle.GetColor()}.");
    }
}