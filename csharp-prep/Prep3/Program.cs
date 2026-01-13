using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string gameRun = "Yes";

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);
            int answer;
            do
            {
                Console.Write("What is your guess? ");
                answer = int.Parse(Console.ReadLine());
                if (answer > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (answer < number)
                {
                    Console.WriteLine("Higher");
                }
            }
            while (answer != number);

            Console.WriteLine("You got it!");

            Console.Write("Do you want to continue? ");
            gameRun = Console.ReadLine();
        } while (gameRun == "yes");
    } 
}