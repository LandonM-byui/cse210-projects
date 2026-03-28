public class DicePool
{
    private List<Dice> _dicePool;

    public DicePool()
    {
        Dice d4 = new Dice(4);
        _dicePool.Add(d4);
        Dice d6 = new Dice(6);
        _dicePool.Add(d6);
        Dice d8 = new Dice(8);
        _dicePool.Add(d8);
        Dice d10 = new Dice(10);
        _dicePool.Add(d10);
        Dice d12 = new Dice(12);
        _dicePool.Add(d12);
        Dice d20 = new Dice(20);
        _dicePool.Add(d20);
    }

    public Dice GetDice(int d)
    {
        if (d == 4)
        {
            return _dicePool[0];
        }
        else if (d == 6)
        {
            return _dicePool[1];
        }
        else if (d == 8)
        {
            return _dicePool[2];
        }
        else if (d == 10)
        {
            return _dicePool[3];
        }
        else if (d == 12)
        {
            return _dicePool[4];
        }
        else if (d == 20)
        {
            return _dicePool[5];
        }
        else
        {
            return null;
        }
    }
}