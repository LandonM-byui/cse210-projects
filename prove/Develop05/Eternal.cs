public class Eternal : Goal
{
    public Eternal(int p, string n, string d) : base(p, n, d){}
    public override string SaveFormatGoal()
    {
        return $"EternalGoal,{GetName()},{GetDescription()},{GetPointVal()},";
    }

    public override int DoGoal()
    {
        return GetPointVal();
    }

    public override string PrintGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
}