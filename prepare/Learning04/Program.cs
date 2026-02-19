using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment problem = new MathAssignment("Landon", "sql", "2", "8-19");
        Console.WriteLine(problem.getSummary());
        Console.WriteLine(problem.GetHomeworkList());

        WritingAssignment problem2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(problem2.getSummary());
        Console.WriteLine(problem2.GetWritingInformation());        
    }
}