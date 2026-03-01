public class Activity
{
    protected int _duration;
    private string _description;
    private string _name;
    private List<string> _animation = ["-", "\\", "|", "/"];

    public Activity(string des, string name)
    {
        _description = des;
        _name = name;
    }

    public void SetDuration(int dur)
    {
        _duration = dur;
    }
    public string GetName()
    {
        return _name;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like your session?");
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine("Get ready...");
        Loading();
    }

    public void Loading()
    {
        Console.WriteLine("");
        for (int i = 0; i< 5; i++)
        {
            foreach (string car in _animation)
            {
                Console.Write(car);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
        }
    }

    public void DisplayEnd()
    {
        Console.WriteLine("Well done!");
        Loading();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Loading();
        Console.Clear();
    }

    public void CountDown(int num)
    {
        while(num > 0)
        {
            Console.Write($"{num}");
            num -= 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}