using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter_grade = " ";
        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }
        Console.Write($"Your letter grade for your class is a {letter_grade}. ");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't pass. You'll surely pass it next time!");
        }

    }
}