public class LegendaryEnemy : Enemy
{
    private int _maxActions;
    private int _curActions;
    private string _actions;
    public LegendaryEnemy (string name, int hp, List<string> res, int cur, int max, string act, int curHP = -1, int init = -10) : base(name, hp, res, curHP,init)
    {
        _maxActions = max;
        _curActions = cur;
        _actions = act;
    }

    public void useAction()
    {
        _curActions -= 1;
    }

    public void recharge()
    {
        _curActions = _maxActions;
    }

    public void printLegendary()
    {
        Console.WriteLine($"{_curActions}/{_maxActions} Options: {_actions}");
    }

}