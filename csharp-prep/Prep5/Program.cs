using System;
using System.Globalization;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromtUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine()); 
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter your birth year: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResults(string name, int num, int year)
    {
        Console.WriteLine($"{name}, the square of your of your number is {num}");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
    static void Main(string[] args)
    {
        string name = PromtUserName();
        int number = PromptUserNumber();
        int year; 
        PromptUserBirthYear(out year);
        int square = SquareNumber(number);
        DisplayResults(name, square, year);

    }
}