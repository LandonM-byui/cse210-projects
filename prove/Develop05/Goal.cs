public abstract class Goal
{
    private int _points;
    private string _name;
    private string _description;

    public Goal(int points, string name, string description)
    {
        _points = points;
        _name = name;
        _description = description;
    }

    public int GetPointVal()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public abstract string SaveFormatGoal();

    public abstract int DoGoal();

    public abstract string PrintGoal();
}