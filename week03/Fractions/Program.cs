using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        Fraction f4 = new Fraction();

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());


        Console.Write("Top: ");
        int top = int.Parse(Console.ReadLine());
        Console.Write("Bottom: ");
        int bottom = int.Parse(Console.ReadLine());

        f4.SetTop(top);
        f4.SetBottom(bottom);

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // learning to use get and set
        // learning to use constructors
    }
}