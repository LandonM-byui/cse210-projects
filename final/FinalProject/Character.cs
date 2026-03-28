public abstract class Character
{
    protected string _name;
    protected int _hp;
    protected int _curHP;
    protected int _initiative;

    public Character (string name, int hp, int curHP = -1, int init = -10)
    {
        _name = name;
        _hp = hp;
        if (curHP >= 0)
        {
            _curHP = curHP;
        }
        else
        {
            _curHP = _hp;
        }
        if (init >= -10)
        {
            _initiative = init;
        }
        else
        {
            _initiative = 0;
        }

    }
    public virtual string getInfo()
    {
        return $"{_name} ({_initiative}): {_curHP}/{_hp}";
    }
    public void heal(int amt)
    {
        if (_curHP + amt <= _hp)
        {
            _curHP += amt;
        }
        else
        {
            _curHP = _hp;
        }
    }
    public void setInitiative(int amt)
    {
        _initiative = amt;
    }

    public int getInitiative()
    {
        return _initiative;
    }
    public abstract void takeDamage(int num);
}