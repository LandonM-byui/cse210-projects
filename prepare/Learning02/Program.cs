using System;

class Program
{
    static void Main(string[] args)
    {
        Job software = new Job();
        software._company = "Direwolf Digital";
        software._jobTitle = "Software Engineer";
        software._startYear = 2024;
        software._endYear = 2025;

        Job boardGame = new Job();
        boardGame._company = "Ledger Games";
        boardGame._jobTitle = "Game Tester";
        boardGame._startYear = 2026;
        boardGame._endYear = 2027;
        software.DisplayJobDetails();
        boardGame.DisplayJobDetails();
        
        Resume my_resume = new Resume();
        my_resume._name = "Landon Mahaffey";
        my_resume._jobs.Add(software);
        my_resume._jobs.Add(boardGame);
        my_resume.DisplayResume();
    }
}