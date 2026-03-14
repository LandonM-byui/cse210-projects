public class Consecutive : Goal
{
    private int _timesCompleted;
    public Consecutive (int p, string n, string d, int times = 0) : base(p, n, d)
    {
        _timesCompleted = times;
    }
    public override string SaveFormatGoal()
    {
        return $"ConsecutiveGoal,{GetName()},{GetDescription()},{GetPointVal()},{_timesCompleted}";
    }

    public override int DoGoal()
    {
        bool succeed = AskForSuccess();
        if (succeed)
        {
            _timesCompleted += 1;
            return GetPointVal() * _timesCompleted;
        }
        else
        {   
            _timesCompleted = 0;
            return -1;
        }
    }
    public bool AskForSuccess()
    {
        Console.Write("Did you succeed in the goal? (Y/N) ");
        if (Console.ReadLine() == "Y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string PrintGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()} -- Currently completed: {_timesCompleted} times)";   
    }
}