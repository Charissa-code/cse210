using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());
        
        Fraction b = new Fraction(5);
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());
        
        Fraction c = new Fraction(3, 4);
        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimalValue());
           
        Fraction d = new Fraction(1, 3);
        Console.WriteLine(d.GetFractionString());
        Console.WriteLine(d.GetDecimalValue());

    }
}