using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity ba = new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing Activity");
        ReflectioningActivity ra = new ReflectioningActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflecting Activity");
        ListeningActivity la = new ListeningActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listening Activity");
        Boolean end = false;
        string option = "";
        Console.Clear();
        do
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listening activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select an number option from the menu: ");        
            option = Console.ReadLine().ToLower();
            Console.Clear();
            if (option == "1")
            {
                ba.RunBreathing();
            }
            else if (option == "2")
            {
                ra.RunReflectioning();
            }
            else if (option == "3")
            {
                la.RunListening();
            }
            else if (option == "4")
            {
                Console.WriteLine("Ending...");
                end = true;
            }
            else
            {
                Console.WriteLine("Please use the numbers to pick an option.");
                Console.Clear();
            }
        }
        while(end != true);
    }
}