using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scripture = new Reference("Proverbs 3:5-6", ["5. Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "6. In all thy ways acknowledge him, and he shall direct thy paths."]);
        bool done = false;
        do
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue, type 'reveal' to reveal, type 'reset' to reset, or type 'quit' to finish.");   
            string response = Console.ReadLine();
            if (response == "quit")
            {
                done = true;
            }
            else if (response == "reset")
            {
                scripture.ResetScriptures();
            }
            else if (response == "" || response == "reveal")
            {
                bool blanks;
                if (response == "")
                {
                    blanks = true;
                }
                else
                {
                    blanks = false;
                }
                Console.WriteLine("");
                Console.WriteLine("How many spaces?");
                int num = int.Parse(Console.ReadLine());
                scripture.ToggleBlanks(num, blanks);
            }
        }
        while(done == false);

    }
}