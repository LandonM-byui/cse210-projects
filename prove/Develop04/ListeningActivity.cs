using System.Security.Cryptography.X509Certificates;

public class ListeningActivity : Activity
{
    private List<string> _entries = [""];
    private List<string> _promts = ["Who are people that you appreciate?",
                                    "What are personal strengths of yours?",
                                    "Who are people that you have helped this week?",
                                    "When have you felt the Holy Ghost this month?",
                                    "Who are some of your personal heroes?"];
    private List<string> _usedPrompts = [];
    private Random rand = new Random();


    public ListeningActivity(string des, string name) : base(des, name)
    {

    }

    public void RunListening()
    {
        _entries.Clear();
        StartMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        if (_promts.Count() == 0)
        {
            foreach (string prompt in _usedPrompts)
            {
                _promts.Add(prompt);
            }
            _usedPrompts.Clear();
        }
        int num = rand.Next(0,_promts.Count);
        Console.WriteLine($" ---{_promts[num]}--- ");
        _usedPrompts.Add(_promts[num]);
        _promts.RemoveAt(num);
        Console.Write("You may begin in: ");
        CountDown(5);
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());
        Console.WriteLine("");
        while (currentTime < futureTime)
        {
            Console.Write(">");
            _entries.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_entries.Count()} items!");
        Console.WriteLine("");
        DisplayEnd();
    }
}