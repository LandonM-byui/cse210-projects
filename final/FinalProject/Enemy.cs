public class Enemy : Character
{
    private Spellcaster _spells = null;
    private List<string> _resistances;

    public Enemy (string name, int hp, List<string> res, int curHP = -1, int init = -10) : base (name, hp, curHP, init)
    {
        _resistances = res;
    }

    public void AddSpells(Spellcaster s)
    {
        _spells = s;
    }

    public void doSpell(int level)
    {
        if (_spells != null)
        {
            _spells.useSpell(level);
        }
    }

    public override void takeDamage(int num)
    {
        Console.WriteLine("What is the damage type? ");
        string type = Console.ReadLine();
        {
            
        }
        if(_resistances.Contains(type))
        {
            float n = num / 2;
            _curHP -= (int)Math.Round(n);
        }
        else
        {
            _curHP -= num;
        }
    }
}