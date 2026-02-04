using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3,4);

        Console.WriteLine($"{f1.GetFractionString()}, {f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()}, {f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()}, {f3.GetDecimalValue()}");

        Fraction f4 = new Fraction();
        var rand = new Random();
        for (int i = 1; i < 21; i++)
        {
            f4.SetFractionN(rand.Next(1,20));
            f4.SetFractionD(rand.Next(1,20));
            Console.WriteLine($"Fraction{i}: string: {f4.GetFractionString()} Number: {f4.GetDecimalValue()}");
        }

    }
}