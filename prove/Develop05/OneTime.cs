public class OneTime : Goal
{
    private bool _complete;
    public OneTime (int p, string n, string d, bool comp = false) : base(p, n, d)
    {
        _complete = comp;
    }
    public override string SaveFormatGoal()
    {
        return $"OneTimeGoal,{GetName()},{GetDescription()},{GetPointVal()},{_complete}";
    }

    public override int DoGoal()
    {
        if (_complete != true)
        {
            _complete = true;
            return GetPointVal();
        }
        else
        {
            return 0;
        }
    }

    public override string PrintGoal()
    {
        string var;
        if (_complete)
        {
            var = "X";
        }
        else
        {
            var = " ";
        }
        return $"[{var}] {GetName()} ({GetDescription()})";   
    }
}