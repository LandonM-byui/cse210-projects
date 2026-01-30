using System;
using System.IO.Enumeration;
using System.IO; 
class Program
{   
    static void Main(string[] args)
    {
        PromptGen _gen = new PromptGen();
        Journal _journal = new Journal();
        int input = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        do {
            Console.WriteLine("Please enter one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");

            input = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (input == 1)
            {
                string prompt = _gen.ReturnPrompt();
                Console.WriteLine(prompt);
                string userResponse = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                _journal.MakeEntry(dateText, prompt, userResponse);
                Console.WriteLine("");
            }
            else if (input == 2)
            {
                _journal.DisplayJournal();
            }
            else if (input == 3)
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                Console.WriteLine("");
                if (System.IO.File.Exists(fileName)){
                    string[] file = System.IO.File.ReadAllLines($"{fileName}");
                    _journal._entries.Clear();

                    /*Password system for opening file*/
                    Console.WriteLine("Please enter the file's password: ");
                    string attempt = Console.ReadLine();
                    Console.WriteLine("");
                    if (attempt == file[0])
                    {
                        foreach (string line in file)
                        {
                            if (line != file[0])
                            {
                            string[] parts = line.Split(",");             
                            _journal.MakeEntry(parts[0], parts[1], parts[2]);    
                            }
                            else
                            {
                                _journal._password = line;
                            }      
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password");
                        file = [];
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid file name and extention.");
                }
            }
            else if (input == 4)
            {
             Console.WriteLine("Name the saved journal: ");
             string filename = Console.ReadLine();
             Console.WriteLine("");
             Console.WriteLine("Add a password to the journal: ");
             string password = Console.ReadLine();
             Console.WriteLine("");
             _journal._password = password;
             _journal.SaveEntries(filename);
                
            }
        } while (input != 5);
    }
}