public class BreathingActivity : Activity
{
    private int _cycle;

    public BreathingActivity (string des, string name) : base(des, name){}

    public void RunBreathing()
    {
        StartMessage();
        _cycle = GetDuration();
        while (_cycle > 0)
        {
            Console.Write("Breath in...");
            CountDown(4);
            Console.WriteLine("");
            Console.Write("Now Breath out...");
            CountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");
            _cycle -= 10;
        }
        DisplayEnd();
    }
}