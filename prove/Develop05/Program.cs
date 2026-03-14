using System;
using System.Runtime.InteropServices;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        int points = 0;
        List<Goal> goals = [];
        do
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (option)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. One Time Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Multi Goal");
                    Console.WriteLine("  4. Consecutive Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalType = int.Parse(Console.ReadLine());
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it?" );
                    string goalDescription = Console.ReadLine();
                    Console.Write("How many points is this worth? ");
                    int pointVal = int.Parse(Console.ReadLine());
                    switch (goalType)
                    {
                        case 1:
                            OneTime t = new OneTime(pointVal, goalName,goalDescription);
                            goals.Add(t);
                            break;
                        case 2:
                            Eternal e = new Eternal(pointVal, goalName, goalDescription);
                            goals.Add(e);
                            break;
                        case 3:
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int req = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonus = int.Parse(Console.ReadLine());
                            Multi m = new Multi(pointVal, goalName, goalDescription, bonus, req);
                            goals.Add(m);
                            break;
                        case 4:
                            Consecutive c = new Consecutive(pointVal, goalName, goalDescription);
                            goals.Add(c);
                            break;
                    }
                    
                    break;

                case 2:
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal.PrintGoal());
                    }
                    break;

                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(points);
                        foreach(Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.SaveFormatGoal());
                        }
                    }
                    break;
                case 4:
                    Console.Write("What is the file name? ");
                    string fileName = Console.ReadLine();
                    Console.WriteLine("");
                    if (System.IO.File.Exists(fileName)){
                        string[] file = System.IO.File.ReadAllLines($"{fileName}");
                        goals.Clear();
                        points = int.Parse(file[0]);
                        foreach(string line in file)
                        {
                            if (line != file[0])
                            {
                                string[] parts = line.Split(",");
                                switch (parts[0]){
                                    case "OneTimeGoal":
                                        OneTime goalo = new OneTime(int.Parse(parts[3]), parts[1] ,parts[2], bool.Parse(parts[4]));
                                        goals.Add(goalo);
                                        break;
                                    case "EternalGoal":
                                        Eternal goale = new Eternal(int.Parse(parts[3]), parts[1] ,parts[2]);
                                        goals.Add(goale);
                                        break;
                                    case "MultiGoal":
                                        Multi goalm = new Multi(int.Parse(parts[3]), parts[1] ,parts[2], int.Parse(parts[4]), int.Parse(parts[5]));
                                        goals.Add(goalm);
                                        break;
                                    case "ConsecutiveGoal":
                                        Consecutive goalc = new Consecutive(int.Parse(parts[3]), parts[1] ,parts[2], int.Parse(parts[4]));
                                        goals.Add(goalc);
                                        break;
                                    
                                }
                            }
                        }
                    }
                    break;   
                case 5:
                    Console.WriteLine("The goals are:");
                    int i = 1;
                    foreach(Goal goal in goals)
                    {
                        Console.WriteLine($"{i}. {goal.GetName()}");
                        i += 1;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int goalNum = int.Parse(Console.ReadLine());
                    int goalAmnt = goals[goalNum - 1].DoGoal();
                    if (goalAmnt > 0)
                    {
                        points += goalAmnt;
                        Console.WriteLine($"Congratulations! You have earned {goalAmnt} points!");
                        Console.WriteLine("");
                    }
                    else if (goalAmnt < 0)
                    {
                        Console.WriteLine("Streak Broken.");
                    }
                    else
                    {
                        Console.WriteLine("This goal has already been completed.");
                    }
                    break;

                case 6:
                    run = false;
                    break;
                default:
                    Console.WriteLine("Please select a valid menu option");
                    break;
            }
            
                        
        }
        while(run == true);
    }
}