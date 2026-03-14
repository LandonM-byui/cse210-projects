public class Multi : Goal
{
    private int _completeBonus;
    private int _required;
    private int _completed;
    public Multi (int p, string n, string d, int bonus, int req, int comp = 0) : base(p, n, d)
    {
        _completeBonus = bonus;
        _required = req;
        _completed = comp;
    }
    public override string SaveFormatGoal()
    {
        return $"MultiGoal,{GetName()},{GetDescription()},{GetPointVal()},{_completeBonus},{_required}, {_completed}";
    }

    public override int DoGoal()
    {
        if (_required != _completed)
        {
            _completed += 1;
            if (_required == _completed)
            {
                return _completeBonus + GetPointVal();
            }
            else
            {
                return GetPointVal();
            }
        }
        else
        {
            return 0;
        }
    }

    public override string PrintGoal()
    {
        string var;
        if (_completed == _required)
        {
            var = "X";
        }
        else
        {
            var = " ";
        }
        return $"[{var}] {GetName()} ({GetDescription()} -- Currently completed: {_completed}/{_required})";   
    }
}