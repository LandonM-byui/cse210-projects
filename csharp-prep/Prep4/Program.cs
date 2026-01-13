using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = 1;
        int currentMax = 0;
        Console.WriteLine("Enter a List of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                if (input > currentMax)
                {
                    currentMax = input;
                }
                numbers.Add(input);
            }
        } while (input != 0);
        float sum = 0;
        foreach (float num in numbers)
        {
            sum += num;
        }
        float average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {currentMax}");
        
    }
}